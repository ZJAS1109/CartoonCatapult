using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañon : MonoBehaviour
{
    public Transform guia;

    void Update(){

        Vector3 mousePosition = Camera.main.WorldToScreenPoint(Input.mousePosition);

        Vector3 direction = mousePosition - transform.position;

        //direction.x = 0;

        //transform.LookAt(0, direction.y, direction.z);
    }
}
