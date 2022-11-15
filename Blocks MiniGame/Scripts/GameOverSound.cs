using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverSound : MonoBehaviour
{
    public AudioSource  audioSource;
    public AudioClip    completed;
    public AudioClip    gameOver;

    public void GameOver()
    {
        SoundPlayer(gameOver);
    }
    public void LevelCompleted()
    {
        SoundPlayer(completed);
    }

    void SoundPlayer(AudioClip sound)
    {
        audioSource.clip = sound;
        audioSource.loop = false;
        audioSource.Play();
    }
}
