using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
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
        SceneManager.LoadScene(sceneName);
    }

    public void ChangeModel(string modelId) {
        if (modelId == "") {
            MainControl.CalculateArea(Controller.currModel.Id);   
        } else {
            MainControl.CalculateArea(modelId);   
        }
    }

    public void ExportPDF(){
        FileStream fs = new FileStream("ARFarm_Result.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
        Document doc = new Document();
        PdfWriter writer = PdfWriter.GetInstance(doc, fs);
        doc.Open();
        doc.Add(new Paragraph("Hello World"));
        doc.Close();
    }

}
