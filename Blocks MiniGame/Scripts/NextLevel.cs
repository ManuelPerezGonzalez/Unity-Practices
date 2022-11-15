using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string   nextLevel;
    public float    await;

    [ContextMenu("Load")]
    public void Load()
    {
        Invoke("LoadLevel", await);
    }

    void LoadLevel()
    {
        if (!IsLastLevel())
            LifesCounter.lifes++;
        SceneManager.LoadScene(nextLevel);
    }

    public bool IsLastLevel()
    {
        /*if (nextLevel == "MainScreen")
            return true;
        else
            return false;*/
        return nextLevel == "MainScreen";
    }
}
