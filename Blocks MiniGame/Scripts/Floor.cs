using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public LifesCounter    lifes;

    void OnTriggerEnter()
    {
        lifes.LoseALife();
    }
}
