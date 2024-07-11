using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject proyectil;

    public float speed = 10f;

    public Transform origen;

    void Update(){

        if(Input.GetMouseButtonDown(0)){
            Disparo();
        }
    }

    public void Disparo(){

        GameObject disparo = Instantiate(proyectil, origen.position, origen.rotation);

        Vector3 apuntado = Input.mousePosition;
        apuntado.z = 3f;
        Vector3 worldposition = Camera.main.ScreenToWorldPoint(apuntado);

        Vector3 direccion = (worldposition - origen.position).normalized;

        Rigidbody rb = disparo.GetComponent<Rigidbody>();

        rb.velocity = direccion * speed;

    }


}
