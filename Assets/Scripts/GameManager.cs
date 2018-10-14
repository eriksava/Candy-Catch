using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Text scoreText;

    public static GameManager instance1;

    int score = 0;

    bool gameOver = false;

    private void Awake()
    {
        instance1 = this;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void IncrementScore(){

        score++;
        scoreText.text = score.ToString();
        Debug.Log(score);
    }
}
