using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class killsscript : MonoBehaviour
{
    public static killsscript instance;

    public Text scoreText;

    int score = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString() + " KILLS";
    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + " KILLS";
    }
}