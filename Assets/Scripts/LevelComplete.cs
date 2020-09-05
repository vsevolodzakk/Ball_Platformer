using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelComplete : MonoBehaviour
{
    public Text cheerText;
    public Button nextLvl;
    AudioSource lvlCompleteSound;

    private void Start()
    {
        lvlCompleteSound = GetComponent<AudioSource>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            cheerText.text = "Level Complete!\n Cheers";
            lvlCompleteSound.Play();
            nextLvl.gameObject.SetActive(true);
        }
    }
}
