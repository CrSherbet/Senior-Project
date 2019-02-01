﻿using System.Collections;
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
        SceneManager.LoadScene(sceneName);
    }

    public void ChangeModel(string modelId) {
        if (modelId == "") {
            MainControl.CalculateArea(Controller.currModel.Id);   
        } else {
            MainControl.CalculateArea(modelId);   
        }
    }
}
