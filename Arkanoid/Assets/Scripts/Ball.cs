using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private Vector2 startSpeed;
    private Rigidbody2D ballRb;
    private bool ballMoving;
    [SerializeField]
    private float ballSpeed;
    [SerializeField]
    Transform playerPaddle;
    
    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            Moving();
        }
    }

    private void FixedUpdate()
    {
        if (ballMoving)
        {
            ballRb.velocity = ballRb.velocity.normalized * ballSpeed;
        }
    }

    private void Moving()
    {
        transform.parent = null;
        ballMoving = true;
        ballRb.velocity = startSpeed.normalized * ballSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Block"))
        {
            Destroy(collision.gameObject);
            GameManager.Instance.DestroyedBlocks();
        }

        if(collision.gameObject.CompareTag("DeathWall"))
        {
            ResetBall();
            LifeSystem.instance.ChangeLives();
        }
    }

    private void ResetBall()
    {
        ballRb.velocity =  Vector2.zero;
        gameObject.transform.parent = playerPaddle;
        gameObject.transform.localPosition = new Vector2 (1.0641f, -2.04f);
        Debug.Log("Reloaded");
    }
}
