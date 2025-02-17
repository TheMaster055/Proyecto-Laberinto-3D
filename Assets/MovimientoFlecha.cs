using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoFlecha : MonoBehaviour
{
    public float speed = 1.0f;
    public float height = 1.0f;

    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        float newY = Mathf.PingPong(Time.time * speed, height);
        transform.position = new Vector3(initialPosition.x, initialPosition.y + newY, initialPosition.z);
    }
}
