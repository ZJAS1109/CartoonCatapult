using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosivo : MonoBehaviour
{
    public GameObject radio;

    public static bool explosivo;

    void Start(){
        radio.SetActive(false);
    }


    public void OnCollisionEnter(Collision other){

        if(other.gameObject.CompareTag("Objetivo") && !explosivo){
            radio.SetActive(true);
            explosivo = true;
        }
    }
}
