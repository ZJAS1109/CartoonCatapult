using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetosMov : MonoBehaviour
{
    public List<Transform> destinos;

    public float velocidad = 5f;

    private int i = 0;

    void Start(){
        transform.rotation = Quaternion.Euler(90, 0, 0);
    }

    void Update(){

        Transform destinoActual = destinos[i];

        transform.position = Vector3.MoveTowards(transform.position, destinoActual.position, velocidad * Time.deltaTime);

        if (Vector3.Distance(transform.position, destinoActual.position) < 0.1f){

            i = (i +1) % destinos.Count;
        }
    }


}
