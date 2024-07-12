using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{

    public GameObject Municion;
    public void OnCollisionEnter(Collision other){

        if(other.gameObject.CompareTag("Objetivo")){
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        if(Explosivo.explosivo){
            Destroy(Municion);
        }
    }
}
