using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour {

    public Text scoreText;

    public GameObject liveHolder;

    public GameObject gameOverPanel; 


    public static GameManager instance1;


    int score = 0;

    int lives = 3;

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

        if(!gameOver){

            score++;
            scoreText.text = score.ToString();
        }
       



    }

    public void DecreaseLife(){

        if(lives > 0){

            lives--;
            liveHolder.transform.GetChild(lives).gameObject.SetActive(false);

        }
        if(lives <= 0){

            gameOver = true;
            GameOver();
        }


    }


    public void GameOver(){

        CandySpawner.instance.StopSpowningCandies();
        GameObject.Find("Player").GetComponent<PlayerController>().canMove = false;
        gameOverPanel.SetActive(true);


    }


   
}
