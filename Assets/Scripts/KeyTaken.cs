using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyTaken : MonoBehaviour
{
    public Text cheer;
    public string keyName;
    //int counter;
    AudioSource keySound;

    private void Start()
    {
        //counter = 0;
        keySound = GetComponent<AudioSource>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            keySound.Play();
            gameObject.SetActive(false);
            cheer.text = $"{gameObject.name} taken!";
        }
            
    }
    private void Update()
    {
        //if (counter > 0)
        //{
        //    counter--;
        //    if (counter == 1)
        //    {
        //        cheer.text = " ";
        //    }
        //}
    }
}
