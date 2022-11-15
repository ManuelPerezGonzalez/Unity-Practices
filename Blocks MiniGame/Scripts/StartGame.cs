using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public InteractiveElement   screen;

    void Update()
    {
        if (Input.GetButtonDown("Fire1") || screen.pressed)
        {
            LifesCounter.lifes = 3;
            PointsCounter.points = 0;
            SceneManager.LoadScene("Level1");
        }
    }
}
