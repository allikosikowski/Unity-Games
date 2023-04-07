using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallReset : MonoBehaviour
{
    public bool PlayerFell;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !PlayerFell)
        {
            PlayerFell = true;
            SceneManager.LoadScene("Level 1");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && PlayerFell)
        {
            PlayerFell = false;
        }
    }
}
