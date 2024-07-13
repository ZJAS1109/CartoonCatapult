using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosivo : MonoBehaviour
{
    public GameObject radio;


    public void OnTriggerEnter(Collider other){

        if(other.gameObject.CompareTag("Objetivo")){
            Instantiate(radio, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
