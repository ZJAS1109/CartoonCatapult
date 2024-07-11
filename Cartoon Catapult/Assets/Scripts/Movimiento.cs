using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movimiento : MonoBehaviour
{
    void Update(){

        Vector3 mousePosition = Input.mousePosition;

        Vector3 screenPositon = Camera.main.ScreenToWorldPoint(mousePosition);

        screenPositon.z = 0f;

        transform.position = screenPositon;
    }
}
