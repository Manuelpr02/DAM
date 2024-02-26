using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puntuaciones : MonoBehaviour
 {
    public Contador scoreManager;
    AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Object1"))
        {
            Destroy(collision.gameObject);
            audioSource.clip = GetComponent<Sonidos>().bonus[0];
            audioSource.Play();
            
            scoreManager.totalScore += 5; 
            Debug.Log("Tu puntuación aumenta en 5");
        }
        else if (collision.collider.CompareTag("Object2"))
        {
            Destroy(collision.gameObject);
            audioSource.clip = GetComponent<Sonidos>().bonus[0];
            audioSource.Play();
            scoreManager.totalScore += 10;
            Debug.Log("Tu puntuación aumenta en 10");
        }
        else if (collision.collider.CompareTag("Puntos"))
        {
            Destroy(collision.gameObject);
            audioSource.clip = GetComponent<Sonidos>().bonus[0];
            audioSource.Play();
            scoreManager.puntototal += 50;
            Debug.Log("Tu puntuación aumenta en 50");
        }
        else if (collision.collider.CompareTag("Object3"))
        {
            audioSource.clip = GetComponent<Sonidos>().Victoria[0];
            audioSource.Play();
            Debug.Log("Tu puntuación final ha sido de " + scoreManager.totalScore);
            Debug.Log("Tu puntuación final especial ha sido de " + scoreManager.puntototal);
        }
        

    }
}