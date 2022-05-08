using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSpawner : MonoBehaviour {

    public GameObject playerPrefab;
	GameObject playerInstance;

	public int numLives = 3111;

	float respawnTimer;

	// Use this for initialization
	void Start () {
		SpawnPlayer();
	}

	void SpawnPlayer() {
		numLives--;
		respawnTimer = 1;
		playerInstance = (GameObject)Instantiate(playerPrefab, transform.position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		if(playerInstance == null && numLives > 0) {
			respawnTimer -= Time.deltaTime;

			if(respawnTimer <= 0) {
				SpawnPlayer();
			}
		}
	}

	 void Restart() {
     //makes a GUI button at coordinates 10, 100, and a size of 200x40
     if(GUI.Button(new Rect( Screen.width/2 - 50 , Screen.height/2 - 5, 100, 50),"Restart")) {
        //Loads a level
	   SceneManager.LoadScene("SampleScene");
     }
 }

	void Back() {
     //makes a GUI button at coordinates 10, 100, and a size of 200x40
     if(GUI.Button(new Rect( Screen.width/2 - 50 , Screen.height/2 - -50, 100, 50),"Back")) {
        //Loads a level
	   SceneManager.LoadScene("Menu");
     }
 }

	void OnGUI() {
		if(numLives > 0 || playerInstance!= null) {
			GUI.Label( new Rect(0, 0, 100, 50), "Lives Left: " + numLives);
		}
		else {
			GUI.Label( new Rect( Screen.width/2 - 35 , Screen.height/2 - 25, 100, 50), "Game Over!");
			Restart();
			Back();
		}
	}
}