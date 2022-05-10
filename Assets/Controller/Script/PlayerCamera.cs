using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public GameObject Boy;
    Vector3 distance;

    void Start()
    {
        distance = transform.position - Boy.transform.position;
    }

    void Update()
    {
        transform.position = Boy.transform.position + distance;
    }
}
