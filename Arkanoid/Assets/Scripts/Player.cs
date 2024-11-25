using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Camera mainCam;
    private float playerY;
    //private float bounds = 1f;

    private void Start()
    {
        mainCam = FindObjectOfType<Camera>();
        playerY = this.transform.position.y;
    }
    void Update()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        float mousePositionWorldX = mainCam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 0, 0)).x;
        this.transform.position = new Vector3(mousePositionWorldX, playerY, 0);
        //Vector2 playerPosition = transform.position;
        //playerPosition.x = Mathf.Clamp(playerPosition.x * Time.deltaTime, -bounds, bounds);
    }
}
