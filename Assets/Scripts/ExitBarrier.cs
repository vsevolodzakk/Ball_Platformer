using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitBarrier : MonoBehaviour
{
    public GameObject GKeyImage;
    public GameObject SKeyImage;
    public bool keyGold;
    public bool keySilver;

    // Start is called before the first frame update
    void Start()
    {
        keyGold = false;
        keySilver = false;
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Transform key in transform)
        {
            if (key.gameObject.name == "Gold Key" && key.gameObject.activeInHierarchy == false)
            {
                keyGold = true;
                GKeyImage.gameObject.SetActive(false);
            }
            if (key.gameObject.name == "Silver Key" && key.gameObject.activeInHierarchy == false)
            {
                keySilver = true;
                SKeyImage.gameObject.SetActive(false);
            }
            if (keyGold && keySilver)
                gameObject.SetActive(false);
        }
    }
}
