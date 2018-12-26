using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnScript : MonoBehaviour {

    void Start() { 

    }

    // Update is called once per frame
    void Update() {

    }

    public void LoadScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }
}
