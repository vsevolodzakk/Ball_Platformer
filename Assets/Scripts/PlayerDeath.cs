using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerDeath : MonoBehaviour
{
    public Text life;
    public Transform respawn;
    public int lifeCount;
    Rigidbody rb;
    public AudioSource hit;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        life.text = "Life: " + lifeCount.ToString();
    }
    public void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "KillZone" && lifeCount > 1)
        {
            transform.position = respawn.position;
            lifeCount--;
            hit.Play();
        }
        else if (other.gameObject.tag == "KillZone" && lifeCount == 1)
        {
            RestartLevel();
        }
    }
    public void RestartLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentLevel);
    }
}
