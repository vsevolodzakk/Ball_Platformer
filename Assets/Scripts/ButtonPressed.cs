using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPressed : MonoBehaviour
{
    public ParticleSystem ps;
    public Light pl;
    private AudioSource blink;
    // Детектор "нажатия" на кнопку
    public GameObject detector;

    private void Start()
    {
        blink = GetComponent<AudioSource>();
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        // Когда игрок нажимает кнопку, то гаснет свет и визуальные эффекты,
        // Детектор нажатия тоже срабатывает
        if (collision.gameObject.tag == "Player" && detector.activeInHierarchy)
        {
            
            var emiter = ps.emission;
            emiter.enabled = false;
            pl.enabled = false;
            detector.SetActive(false);
            blink.Play();
        }
    }
}
