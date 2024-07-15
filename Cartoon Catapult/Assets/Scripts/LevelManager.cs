using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public List<GameObject> objetivos1;

    public List<GameObject> objetivos2;

    private int actual;

    public static int objetivosRestantes;

    public int oleadaActual;

    void Start(){
        actual = 0;
        oleadaActual = 1;

        StartCoroutine(Aparicion1());
        StartCoroutine(ControlOleada());
        //InvokeRepeating("Aparicion", 0, 0.5f);
    }

    /*
    public void Aparicion(){
        objetivos1[actual].SetActive(true);

        actual++;

        if(actual > 7){
            CancelInvoke("Aparicion");
        }
    }*/

    IEnumerator Aparicion1(){

        objetivosRestantes = 7;

        yield return new WaitForSecondsRealtime(0.5f);

        while(actual < 7){
            objetivos1[actual].SetActive(true);
            actual ++;

            yield return new WaitForSecondsRealtime(0.5f);
        }

        //objetivosRestantes = 7;
    }

    IEnumerator Aparicion2(){

        objetivosRestantes = 7;

        yield return new WaitForSecondsRealtime(0.5f);

        while(actual < 7){
            objetivos2[actual].SetActive(true);
            actual ++;

            yield return new WaitForSecondsRealtime(0.5f);
        }

    }



    IEnumerator ControlOleada(){

        yield return new WaitUntil(() => objetivosRestantes == 0);
        oleadaActual ++;
        Oleada();
    }

    public void Oleada(){

        if(oleadaActual == 2){
            StartCoroutine(Aparicion2());
        }
    }
}
