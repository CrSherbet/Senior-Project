using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CameraBtnScript : MonoBehaviour {

    void Start() {
    }

    void Update() {
    }

    public void SetPosition(){
       PointCloudParticleExample.PointUpdated = true;
    }
}