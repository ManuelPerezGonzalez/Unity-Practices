using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    public Vector3 rotate = new Vector3(0, 0, 0);

    void Update()
    {
        transform.Rotate(rotate * Time.deltaTime);
    }
}
