using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador : MonoBehaviour
{
    public TMPro.TMP_Text text;
    public TMPro.TMP_Text text2;
    public int totalScore = 0; 
    public int puntototal = 0;

    private void Update()
    {
        text.text = "Puntuaci�n: " + totalScore;
        text2.text = "Puntuaci�n Especial: " + puntototal;
    }

}
