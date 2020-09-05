using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoToStart : MonoBehaviour
{
    public GameObject startMarker;
    public Text life;
    public int lifeCount;

    void Update()
    {
        life.text = "Life: " + lifeCount.ToString();
    }
    public void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.tag == "Player") && (lifeCount > 0))
        {
            collision.gameObject.transform.position = startMarker.transform.position;
            lifeCount--;
            
            
        } else if (lifeCount == 0)
        {
            SceneManager.LoadScene("Level1-Proto");
        }
    }
}
