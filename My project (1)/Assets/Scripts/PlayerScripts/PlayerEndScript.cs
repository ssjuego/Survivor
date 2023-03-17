using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerEndScript : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Attacker"))
        {
            SceneManager.LoadScene("PlayerDead");
        }

        if (collider.gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene("EndGame");
        }
    }
}
