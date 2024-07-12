using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public void OnCollisionEnter(Collision other){

        if(other.gameObject.CompareTag("Objetivo")){
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
