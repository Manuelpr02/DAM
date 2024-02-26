using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float cooldownAtaque;
    private SpriteRenderer spriteRenderer;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Personaje")) {

         

            // Perdemos una vida.
            GameManager.Instance.PerderVida();

            // Aplicamos golpe al personaje.
            other.gameObject.GetComponent<CharacterController>().AplicarGolpe();

    
        }
    }
}
