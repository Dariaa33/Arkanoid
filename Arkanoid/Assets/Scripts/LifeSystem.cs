using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSystem : MonoBehaviour
{
    public GameObject[] hearts;
    public int life;
    void Start()
    {
        
    }

    void Update()
    {
        /*if (life < 1)
        {
            Destroy(hearts[0].gameObject);
        }
        else if (life < 2)
        {
            Destroy(hearts[1].gameObject);
        }
        else if (life < 3)
        {
            Destroy(hearts[2].gameObject);
        }*/
    }

    /*public void LooseHeart(int h)
    {
        life -= h;
    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("LifeSystem"))
        {
            Destroy(hearts[0].gameObject);

        }
    }
}