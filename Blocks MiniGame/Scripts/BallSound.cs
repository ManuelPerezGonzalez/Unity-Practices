using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSound : MonoBehaviour
{
    public AudioSource bounce;
    public AudioSource point;
    public AudioSource error;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Block"))
            point.Play();
        else if (other.gameObject.CompareTag("Floor"))
            error.Play();
        else
            bounce.Play();
    }
}
