using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextCtrl : MonoBehaviour
{
    private int score = 0;
    Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score = DataManager.score;
        scoreText.text = "Score: " + score;
    }
}
