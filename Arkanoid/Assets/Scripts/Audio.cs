using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField]
    AudioSource music;
    [SerializeField]
    AudioSource sFX;

    public AudioClip audioBG;
    public AudioClip GameOver;
    public AudioClip breakBlock;
    public AudioClip deathWall;
    void Start()
    {
        music.clip = audioBG;
        music.Play();
    }

    void Update()
    {
        
    }

    public void playGameOver()
    {
        music.clip = GameOver;
        music.Play();
    }

    public void playSFX(AudioClip clip)
    {
        sFX.PlayOneShot(clip);
    }
}
