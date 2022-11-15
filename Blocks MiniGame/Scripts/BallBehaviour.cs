using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    public Rigidbody            rb;
    public float                speed;
    bool                        playing;
    Vector3                     ballSpawnPoint;
    public Transform            player;
    public InteractiveElement   screen;

    void Start()
    {
        ballSpawnPoint = transform.position;
    }

    void Update()
    {
        if (!playing && (Input.GetButtonDown("Fire1") || screen.pressed))
        {
            playing = true;
            transform.SetParent(null);
            rb.isKinematic = false;
            rb.AddForce(new Vector3(speed, speed, 0));
        }
    }

    public void Reset()
    {
        transform.position = ballSpawnPoint;
        transform.SetParent(player);
        playing = false;
        StopMovement();
    }

    public void StopMovement()
    {
        rb.isKinematic = true;
        rb.velocity = Vector3.zero;
    }
}
