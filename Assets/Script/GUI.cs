using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUI : MonoBehaviour {

    public Text tetris;
    public Text scoreText;
    public int ready = 0;
    private static int score;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        score = SpawnT.scoreInt;
        scoreText.text = "Score = " + score;

        if (ready == 1)
        {
            tetris.text = "Next Block Is Ready, 'Space' To deploy ";
        }

        else
        {
            tetris.text = " ";
        }



    }
}