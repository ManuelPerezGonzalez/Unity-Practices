using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 relativePos;

    void Start()
    {
        relativePos = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + relativePos;
    }
}
