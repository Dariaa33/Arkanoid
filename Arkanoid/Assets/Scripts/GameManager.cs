using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int blocks;
    public static GameManager Instance {  get; private set; }

    [SerializeField] GameObject startMenu;

    public int points;

    [SerializeField] TextMeshProUGUI pointsText;

    [SerializeField] GameObject[] positions;
    [SerializeField] GameObject[] bricksObjects;
    [SerializeField] int bricksAmount;

    [SerializeField] Transform brickParent;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    void Start()
    {
        blocks = GameObject.FindGameObjectsWithTag("Block").Length;
        startMenu.SetActive(true);
    }

    
    void Update()
    {
        
    }

    public void DestroyedBlocks()
    {
        blocks--;
        if(blocks == 0)
        {
            NextLevel();
        }
    }

    private void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void StartGame()
    {
        startMenu.SetActive(false);
        Timer.instance.timerRunning = true;
        int wantedBricks = bricksAmount;
        for (int i = 0; i < wantedBricks; i++)
        {
            int selectedPosition = Random.Range(0, bricksAmount);
            if (positions[selectedPosition].activeSelf == false)
            {
                int selectedBlock = Random.Range(0, bricksObjects.Length);
                GameObject createdObject = Instantiate(bricksObjects[selectedBlock], positions[selectedPosition].transform.position, Quaternion.identity);
                createdObject.transform.parent = brickParent;
            }
            else
            {
                wantedBricks++;
                if (wantedBricks >= 1000)
                {
                    break;
                }
            }
        }
    }

    public void Points()
    {
        pointsText.text = points.ToString();
    }
}
