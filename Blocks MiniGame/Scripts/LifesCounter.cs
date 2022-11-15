using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifesCounter : MonoBehaviour
{
    public static int       lifes = 3;
    public Text             lifesText;
    public BallBehaviour    ball;
    public PlayerController player;
    public GameObject       gameOver;
    public NextLevel        nextLevel;
    public GameOverSound    gameOverSound;

    void Start()
    {
        UpdateLifesCount();
    }

    void UpdateLifesCount()
    {
        lifesText.text = "Lifes: " + LifesCounter.lifes;
    }

    public void LoseALife()
    {
        if (lifes <= 0) return;

        LifesCounter.lifes--;
        UpdateLifesCount();

        if (lifes <=0)
        {
            gameOverSound.GameOver();
            gameOver.SetActive(true);
            ball.StopMovement();
            player.enabled = false;
            nextLevel.nextLevel = "MainScreen";
            nextLevel.Load();
        }
        else
        {
            player.Reset();
            ball.Reset();
        }
    }
}
