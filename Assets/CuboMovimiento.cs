using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboMovimiento : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        Vector3 movimiento = Vector3.zero;

        if (Input.GetKey(KeyCode.A))
        {
            movimiento.x += velocidad * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movimiento.z += velocidad * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movimiento.x -= velocidad * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            movimiento.z -= velocidad * Time.deltaTime;
        }

        transform.Translate(movimiento);
    }
}
