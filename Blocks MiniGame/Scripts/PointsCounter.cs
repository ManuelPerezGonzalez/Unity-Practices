using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsCounter : MonoBehaviour
{
    public static int       points = 0;
    public Text             pointsText;
    public GameObject       levelCompleted;
    public GameObject       gameCompleted;
    public NextLevel        nextLevel;
    public BallBehaviour    ball;
    public PlayerController player;
    public Transform        blocksContainer;
    public GameOverSound    gameOverSound;

    void Start()
    {
        UpdatePointsCount();
    }

    void UpdatePointsCount()
    {
        pointsText.text = "Points: " + PointsCounter.points;
    }

    public void GainPoint()
    {
        PointsCounter.points++;
        UpdatePointsCount();
        if (blocksContainer.childCount <= 0)
        {
            ball.StopMovement();
            player.enabled = false;

            if (nextLevel.IsLastLevel())
                gameCompleted.SetActive(true);
            else
                levelCompleted.SetActive(true);
            gameOverSound.LevelCompleted();
            nextLevel.Load();
        }
    }
}
