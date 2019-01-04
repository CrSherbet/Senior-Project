using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AccessMain : MonoBehaviour {

    private float timer = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if(timer > 2.0f) {
            AccessMainPage();
        }      
	}

    public void AccessMainPage () {
        SceneManager.LoadScene("MainScene");
    }
    
}
