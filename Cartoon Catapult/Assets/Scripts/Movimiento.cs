using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Movimiento : MonoBehaviour
{
   void Update(){

        SeguirRaton();
   }

   public void SeguirRaton(){

        Vector3 mousePosition = Input.mousePosition;

        mousePosition.z = 5f;

        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
   }
}
