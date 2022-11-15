using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public bool exit;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (exit)
                Application.Quit();
            else
                SceneManager.LoadScene("MainScreen");
        }
    }
}
