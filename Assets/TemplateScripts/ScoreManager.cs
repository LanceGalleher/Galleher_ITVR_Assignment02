using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text infoText;

    public static int scoreCount;

    private bool infoHidden = false;

    void Update()
    {
        scoreText.text = "Pieces Found: " + scoreCount;

        if (!infoHidden && scoreCount >= 1)
        {
            infoText.gameObject.SetActive(false);
            infoHidden = true;
        }
    }

    public void AddScore(int amount)
    {
        scoreCount += amount;
    }
}