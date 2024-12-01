using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoard : MonoBehaviour
{
    [SerializeField]
    private float speed;
  
    private float limitspos = 6.67f; // limits for Clamp method
    private float limitsneg = 3.5f;
    void Start()
    {
        
    }

    void Update()
    {
        float movement = Input.GetAxisRaw("Horizontal"); // keyboard movement
        transform.position += new Vector3(movement * speed * Time.deltaTime, 0f, 0f);
      
        Vector2 positionPlayer = transform.position;
        positionPlayer.x = Mathf.Clamp(positionPlayer.x + movement * speed * Time.deltaTime, limitsneg, limitspos); // setting limits to player
        transform.position = positionPlayer;
    }
}
