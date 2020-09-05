using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyLocker : MonoBehaviour
{
    public bool buttonOne = false;
    public bool buttonTwo = false;
    public bool buttonThree = false;
    public GameObject barrier;

    void Update()
    {
        // Проверяем дочерние объекты
        foreach (Transform i in transform)
        {
            // Определяем GameObject барьера перед ключом
            if (i.gameObject.name == "Barrier")
                barrier = i.gameObject;
            // Проверяем дочерний объект в кнопке Detector,
            //      который сигнализирует, что кнопка нажата
            foreach (Transform j in i)
            {
                if (j.gameObject.name == "Detector1" && j.gameObject.activeInHierarchy == false)
                    buttonOne = true;
                else if (j.gameObject.name == "Detector2" && j.gameObject.activeInHierarchy == false)
                    buttonTwo = true;
                else if (j.gameObject.name == "Detector3" && j.gameObject.activeInHierarchy == false)
                    buttonThree = true;
            }
        }
        // Когда нажаты все кнопки, барьер исчезает
        if (buttonOne && buttonTwo && buttonThree)
            barrier.SetActive(false);
    }
}
