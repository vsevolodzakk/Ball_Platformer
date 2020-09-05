using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checkpoint : MonoBehaviour
{
    public GameObject startMarker;
    public Text cheerText;
    int counter;
    AudioSource cheerSound;
    private bool taken;

    private void Start()
    {
        counter = 0;
        cheerSound = GetComponent<AudioSource>();
        taken = true;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && taken == true)
        {
            startMarker.transform.position = gameObject.transform.position;
            cheerText.text = "Checkpoint!";
            counter = 120;
            cheerSound.Play();
            taken = false;
        }
    }
    void Update()
    {
        if (counter > 0)
        {
            counter--;
            if (counter == 1)
            {
                cheerText.text = " ";
            }
        }
    }
}
