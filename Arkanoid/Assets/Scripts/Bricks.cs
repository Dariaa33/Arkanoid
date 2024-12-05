using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    [SerializeField] int brickLives;
    [SerializeField] int pointsGive;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        brickLives = brickLives - 1;
        if (brickLives == 0)
        {
            Destroy(gameObject);
            GameManager.Instance.points = GameManager.Instance.points + pointsGive;
            GameManager.Instance.Points();
        }
    }
}
