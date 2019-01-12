using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnScript : MonoBehaviour {

    public Controller MainControl;
    
    void Start() { 
        MainControl = new Controller();
    }

    // Update is called once per frame
    void Update() {

    }

    public void LoadScene(string sceneName) {
        if(sceneName == "ModelScene"){
            MainControl.CalculateArea();
        }
        SceneManager.LoadScene(sceneName);
    }
}
