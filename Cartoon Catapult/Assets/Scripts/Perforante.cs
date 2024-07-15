using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perforante : MonoBehaviour
{

    void Start(){
        Destroy(gameObject, 3f);
    }

    public void OnTriggerEnter(Collider other){

        if(other.gameObject.CompareTag("Objetivo")){
            LevelManager.objetivosRestantes --;
            HUD.puntuacion += 100;
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Level")){
            Destroy(gameObject);
        }
    }
}
