using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUIController : MonoBehaviour
{
    public ScoreManager scoreManager;
    public TMP_Text scoreText;

    void Start()
    {
        scoreText.text = scoreManager.score.ToString();
    }

    void Update()
    {
        scoreText.text = scoreManager.score.ToString();
    }
}
