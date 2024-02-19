using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puntuaciones : Contador
 {
    public Contador scoreManager; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Object1"))
        {
            Destroy(collision.gameObject); 
            scoreManager.totalScore += 5; 
            Debug.Log("Tu puntuación aumenta en 5");
        }
        else if (collision.collider.CompareTag("Object2"))
        {
            Destroy(collision.gameObject);
            scoreManager.totalScore += 10;
            Debug.Log("Tu puntuación aumenta en 10");
        }
        else if (collision.collider.CompareTag("Object3"))
        {
            Debug.Log("Tu puntuación final ha sido de " + scoreManager.totalScore);
        }

    }
}