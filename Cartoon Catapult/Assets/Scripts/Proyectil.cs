using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public void OnTriggerEnter(Collider other){

        if(other.gameObject.CompareTag("Objetivo")){
            LevelManager.objetivosRestantes --;
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
