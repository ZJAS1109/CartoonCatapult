using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañon : MonoBehaviour
{
    public Transform guia;

    public Transform cañon;

    private void Update(){
        
        Apuntado();
    }

    private void Apuntado(){

        Vector3 Orientacion = guia.position - transform.position;
        Debug.DrawRay(transform.position, Orientacion, Color.red);

        transform.rotation = Quaternion.LookRotation(Orientacion);
    }
}
