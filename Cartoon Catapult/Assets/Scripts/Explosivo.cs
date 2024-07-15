using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosivo : MonoBehaviour
{
    public GameObject radio;

    public GameObject explosivo;

    void Start(){
        Destroy(gameObject, 3f);
    }

    public void OnTriggerEnter(Collider other){

        if(other.gameObject.CompareTag("Objetivo")){
            //LevelManager.objetivosRestantes --;
            //HUD.puntuacion += 100;
            Instantiate(radio, transform.position, transform.rotation);
            Instantiate(explosivo, transform.position, transform.rotation);
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("Level")){
            Destroy(gameObject);
        }
    }
}
