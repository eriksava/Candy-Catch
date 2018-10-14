using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {



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
        Debug.Log(score);
    }
}
