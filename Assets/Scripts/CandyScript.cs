using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player"){

            GameManager.instance1.IncrementScore();
            Destroy(gameObject);
        }

        else if(col.gameObject.tag == "Boundary"){

            //Tenemos que decrement las vidas
            GameManager.instance1.DecreaseLife();
            Destroy(gameObject);

        }
        
    }

}
