using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private Vector2 startSpeed;
    private Rigidbody2D ballRb;
    private bool ballMoving;
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

    private void Moving()
    {
        transform.parent = null;
        ballMoving = true;
        ballRb.velocity = startSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Block"))
        {
            Destroy(collision.gameObject);
            GameManager.Instance.DestroyedBlocks();
        }
    }
}
