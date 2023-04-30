using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditRollController : MonoBehaviour
{
    float time;
    
    void Start()
    {
        time = 0;
    }

    void Update()
    {
        time += Time.deltaTime;
        if(time > 8)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
