using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUD : MonoBehaviour
{
    public TextMeshProUGUI texto;

    public static int puntuacion;

    void Start(){
        puntuacion = 0;
    }

    void Update(){
        texto.text = $"{puntuacion}";
    }
}
