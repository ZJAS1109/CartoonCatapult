using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public List<GameObject> objetivos1;

    public List<GameObject> objetivos2;

    public List<GameObject> Municion;

    public Transform guiaBala;

    [SerializeField]private int balaEquipada;

    [SerializeField]private int actual;

    public static int objetivosRestantes;

    public int oleadaActual;

    void Start(){
        actual = 0;
        oleadaActual = 1;
        balaEquipada = 0;

        MunicionActual(0);

        StartCoroutine(Aparicion1());
        StartCoroutine(ControlOleada());
    }


    IEnumerator Aparicion1(){

        objetivosRestantes = 7;

        yield return new WaitForSecondsRealtime(0.5f);

        while(actual < 7){
            objetivos1[actual].SetActive(true);
            actual ++;

            yield return new WaitForSecondsRealtime(0.5f);
        }

    }

    IEnumerator Aparicion2(){

        objetivosRestantes = 9;

        yield return new WaitForSecondsRealtime(0.1f);

        while(actual < 9){
            objetivos2[actual].SetActive(true);
            actual ++;

            yield return new WaitForSecondsRealtime(0.1f);
        }

    }



    IEnumerator ControlOleada(){

        yield return new WaitUntil(() => objetivosRestantes == 0);
        actual = 0;
        oleadaActual ++;
        Oleada();
    }

    public void Oleada(){

        if(oleadaActual == 2){
            StartCoroutine(Aparicion2());
        }
    }

    void Update(){

        if(Input.GetKeyDown(KeyCode.Q)) {
            Cambio(true);
        }

        if(Input.GetKeyDown(KeyCode.E)){
            Cambio(false);
        }
    }

    public void Cambio(bool cambio){    
        if(cambio){
            balaEquipada = (balaEquipada + 1) % Municion.Count;
            
        }
        else{
            balaEquipada --;

            if(balaEquipada < 0){
                balaEquipada = Municion.Count -1;
            } 
        }

        MunicionActual(balaEquipada);
    }

    public void MunicionActual(int i){

        foreach(GameObject g in Municion){
            g.SetActive(false);
        }

        Municion[i].SetActive(true);
    }
}
