using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ajustes : MonoBehaviour
{
    [SerializeField]
    GameObject options;
    /*[SerializeField]
    float timeAnim;*/
    void Start()
    {
        options.SetActive(false);
    }

    void Update()
    {
        
    }

    public void ShowOptions()
    {
        options.SetActive(true);
    }
}
