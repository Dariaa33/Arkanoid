using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeSystem : MonoBehaviour
{
    public static LifeSystem instance;
    [SerializeField]
    GameObject[] heart;
    [SerializeField]
    public int lives;

    [SerializeField]
    GameObject phone;
    [SerializeField]
    GameObject background;
    [SerializeField]
    Sprite normalBackground;
    [SerializeField]
    Sprite gameOverBackground;
    [SerializeField]
    LeanTweenType phoneDownAnimation;
    [SerializeField]
    float phoneDownSpeed;
    SpriteRenderer phoneSpriteRenderer;
    Audio audioManager;
   
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<Audio>();
        if (instance == null)
        {
            instance = this;
        }
        else Destroy(this);
    }

    void Start()
    {
        phoneSpriteRenderer = background.GetComponent<SpriteRenderer>();
    }

    public void ChangeLives()
    {
        lives--;
        heart[lives].gameObject.SetActive(false);
        if (lives == 0)
        {
            phoneSpriteRenderer.sprite = gameOverBackground;
            LeanTween.moveLocalY(phone, -13, phoneDownSpeed).setEase(phoneDownAnimation);
            audioManager.playGameOver();

        }
    }
}
