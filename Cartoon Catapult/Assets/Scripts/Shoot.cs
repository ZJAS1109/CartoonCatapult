using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public List<GameObject> proyectil;

    public int proyectilActual;

    public float speed = 10f;

    public Transform origen;

    void Start(){
        proyectilActual = 0;
    }

    void Update(){

        if(Input.GetMouseButtonDown(0)){
            Disparo(proyectilActual);
        }

        if(Input.GetKeyDown(KeyCode.Q)){
            Cambio(true);
        }

        if(Input.GetKeyDown(KeyCode.E)){
            Cambio(false);
        }
    }

    public void Disparo(int num){

        GameObject disparo = Instantiate(proyectil[num], origen.position, origen.rotation);

        Vector3 apuntado = Input.mousePosition;
        apuntado.z = 5f;
        Vector3 worldposition = Camera.main.ScreenToWorldPoint(apuntado);

        Vector3 direccion = (worldposition - origen.position).normalized;

        Rigidbody rb = disparo.GetComponent<Rigidbody>();

        rb.velocity = direccion * speed;

    }

    public void Cambio(bool i){
        
        if(i){
            proyectilActual ++;
        }
        else{
            proyectilActual --;
        }

        if(proyectilActual > (proyectil.Count - 1)){
            proyectilActual = 0;
        }
        else if(proyectilActual < 0){
            proyectilActual = proyectil.Count - 1;
        } 
    }
}
