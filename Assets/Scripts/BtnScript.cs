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
    // public UILabel Label2;
    // public UILabel Label;
    private string path;
    public Text test;


    void Start() {
        MainControl = new Controller();
    }
     void Awake()
    {
        path = "~/Library/Mobile/Documents/iCloud~com~apple~iBooks/Documents/";
        // Label2.text = Application.persistentDataPath;
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

    public void ExportPDF(Text test){
        // FileStream fs = new FileStream("ARFarm_Result.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
        Document doc = new Document();
         try
        {
            PdfWriter.GetInstance(doc, new FileStream(path + "/" + "ARFarm_Result" + ".pdf", FileMode.Create ));
            test.text = path;
        }
        catch(System.Exception e)
        {
            // Label.text = e.ToString();
        }
        // PdfWriter writer = PdfWriter.GetInstance(doc, fs);
        doc.Open();
        doc.Add(new Paragraph("Hello World"));
        doc.Close();
    }

}
