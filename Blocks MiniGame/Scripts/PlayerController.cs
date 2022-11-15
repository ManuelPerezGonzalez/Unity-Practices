using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float    speed;
    Vector3         playerSpawnPoint;

    public InteractiveElement   leftButton;
    public InteractiveElement   rightButton;

    void Start()
    {
        playerSpawnPoint = transform.position;
    }

    void Update()
    {
        float   direction;

        if (leftButton.pressed)
            direction = -1;
        else if (rightButton.pressed)
            direction = 1;
        else
            direction = Input.GetAxisRaw("Horizontal");

        /*float direction = leftButton.pressed ?
            -1 :
            (rightButton.pressed ?
            1 :
            Input.GetAxisRaw("Horizontal"));*/

        float posX = transform.position.x + (direction * speed * Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(posX, -8, 7), transform.position.y, transform.position.z);
    }

    public void Reset()
    {
        transform.position = playerSpawnPoint;
    }
}
