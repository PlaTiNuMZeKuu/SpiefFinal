using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;


    public Text scoreText;
   


    int score = 0;


    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    private void Start()
    {
        if (scoreText != null)
        {
            scoreText.text = score.ToString() + " Points";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + "Points";
    }
    public void AddPoints(int amount)
    {
        score += amount;
        scoreText.text = score.ToString() + "Points";
    }
}
