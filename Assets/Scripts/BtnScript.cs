﻿using System;
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

    public static Controller MainControl;
    static int OpenTime = 0;
    
    void Start() { 
        if(OpenTime>1){
            Destroy(GameObject.Find("Tutorial"));
        }
        MainControl = new Controller(); 
        if(SceneManager.GetActiveScene().name == "ModelScene"){
            StartCoroutine(CaptureScreen("Blueprint.png"));
            Model3DController.originalRotationValue = new Quaternion(0f, 0f, 0f, 0f);
        }
    }

    void Update() {
    
    }
    
    public void CapScreenAfterTutorial(string btnName){
        if(btnName == "3D"){
            StartCoroutine(CaptureScreen("3DBlueprint.png"));
            Destroy(GameObject.Find("Tutorial2"));
        } else {
            StartCoroutine(CaptureScreen("Blueprint.png"));
            Destroy(GameObject.Find("Tutorial"));
        }
    }

    IEnumerator CaptureScreen(string filename) {
        yield return new WaitForEndOfFrame();
        int width = 850;
        int height = 850;
        if(filename == "AR.png"){
            width = Screen.width;
            height = Screen.height;
        }
        Texture2D tex = new Texture2D(width, height, TextureFormat.RGB24, false);
        if(filename == "AR.png"){
            tex.ReadPixels(new Rect(0, 0, width, height), 0, 0);
        } else {
            tex.ReadPixels(new Rect(110, 815, width, height), 0, 0);
        }
        tex.Apply();
        byte[] bytes = tex.EncodeToPNG();
        Destroy(tex);
        File.WriteAllBytes(Application.streamingAssetsPath + "/FileforPDF/" + filename, bytes);
    }

    IEnumerator ClearFile() {
        if(File.Exists(Application.streamingAssetsPath + "/FileforPDF/3DBlueprint.png")){
            File.Delete(Application.streamingAssetsPath + "/FileforPDF/3DBlueprint.png");
        }
        
        yield return null;
    }

    public void DestroyTutorial(GameObject tutorial){
        OpenTime++;
        if(OpenTime>2){
            Destroy(tutorial);
        }
    }

    public void LoadScene(string sceneName) {
        OpenTime++;
        if(sceneName == "ModelScene"){
            StartCoroutine(ClearFile());
        }
        SceneManager.LoadScene(sceneName);
    }

    public void SetCurrId(string ModelId){
        MainControl.SetId(ModelId); 
    }

    public void ChangeModel() {
        MainControl.CalculateArea();   
    }

    public void SetBtnActive(GameObject setting){
        if(setting.active){
            setting.SetActive(false);
        } else {
            setting.SetActive(true);
        }
    }

    public void SetUp3DModel(Transform model){
        model.GetComponent<Transform>().rotation = Model3DController.originalRotationValue;
        StartCoroutine(CaptureScreen("3DBlueprint.png"));
    }

    public void ExportPDF(GameObject Saved){
        if(SceneManager.GetActiveScene().name == "ArScene"){
            StartCoroutine(CaptureScreen("AR.png"));
        }
        StartCoroutine(CreatePDF());
        new NativeShare().AddFile(Application.streamingAssetsPath + "/ARFarm_Result.pdf").Share();
        Saved.SetActive(true);
    }

    IEnumerator CreatePDF(){
        Pond[] pond = new Pond().getDetail();
        Tree[] tree = new Tree().getDetail();
        RiceField[] rice = new RiceField().getDetail();
        House house = new House().getDetail();
			
        BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
        iTextSharp.text.Font headerFont = new iTextSharp.text.Font(bf, 20, 0, new iTextSharp.text.BaseColor(178, 34, 34));
        iTextSharp.text.Font suggFont = new iTextSharp.text.Font(bf, 18, 0);
        Chunk linebreak = new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(1f, 100f, new iTextSharp.text.BaseColor(0,0,0) , Element.ALIGN_CENTER, -1));
        iTextSharp.text.Image houseImg = iTextSharp.text.Image.GetInstance(Application.streamingAssetsPath + "/FileforPDF/House.png");
        houseImg.ScaleAbsolute(250f, 170f);
        houseImg.Alignment = Element.ALIGN_CENTER;
        iTextSharp.text.Image pondImg = iTextSharp.text.Image.GetInstance(Application.streamingAssetsPath + "/FileforPDF/Pond.png");
        pondImg.ScaleAbsolute(250f, 170f);
        pondImg.Alignment = Element.ALIGN_CENTER;
        iTextSharp.text.Image treeImg = iTextSharp.text.Image.GetInstance(Application.streamingAssetsPath + "/FileforPDF/Tree.png");
        treeImg.ScaleAbsolute(250f, 170f);
        treeImg.Alignment = Element.ALIGN_CENTER;
        iTextSharp.text.Image riceImg = iTextSharp.text.Image.GetInstance(Application.streamingAssetsPath + "/FileforPDF/Rice.png");
        riceImg.ScaleAbsolute(250f, 170f);
        riceImg.Alignment = Element.ALIGN_CENTER;

        iTextSharp.text.Image blueprintImg = iTextSharp.text.Image.GetInstance(Application.streamingAssetsPath + "/FileforPDF/Blueprint.png");
        blueprintImg.Alignment = Element.ALIGN_CENTER;
        blueprintImg.ScaleAbsolute(170f, 170f);
        iTextSharp.text.Image blueprint3DImg = blueprintImg;
        if(File.Exists(Application.streamingAssetsPath + "/FileforPDF/3DBlueprint.png")){    
            blueprint3DImg = iTextSharp.text.Image.GetInstance(Application.streamingAssetsPath + "/FileforPDF/3DBlueprint.png");
            blueprint3DImg.Alignment = Element.ALIGN_CENTER;
            blueprint3DImg.ScaleAbsolute(170f, 170f);
        }

        iTextSharp.text.Image ARImg = blueprintImg;
        if(File.Exists(Application.streamingAssetsPath + "/FileforPDF/AR.png")){    
            ARImg = iTextSharp.text.Image.GetInstance(Application.streamingAssetsPath + "/FileforPDF/AR.png");
            ARImg.Alignment = Element.ALIGN_CENTER;
            ARImg.ScaleAbsolute(170f, 302f);
        }

        FileStream fs = new FileStream("ARFarm_Result.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
        Document doc = new Document();
        try {
            PdfWriter.GetInstance(doc, new FileStream(Application.streamingAssetsPath + "/ARFarm_Result.pdf", FileMode.Create));
        } catch(System.Exception e){
            Debug.Log(e);
        }
        
        Paragraph header = new Paragraph("Result of Analyzation", headerFont);       
        Paragraph TextUnderBlueprint = new Paragraph("\nAllocated Blueprint\n");
        TextUnderBlueprint.Alignment = Element.ALIGN_CENTER;
        Paragraph TextUnder3D = new Paragraph("\n3D Model or Screen Shot");
        TextUnder3D.Alignment = Element.ALIGN_CENTER;
        Paragraph TextUnderAR = new Paragraph("\nScreen Shot");
        TextUnder3D.Alignment = Element.ALIGN_CENTER;
        Paragraph sugg = new Paragraph("Suggestion\n", suggFont);
       
        doc.Open();
        doc.Add(header);
        doc.Add(new Paragraph("Date: " + DateTime.Now.ToString("dddd, dd MMMM yyyy") + "\nTime: " + DateTime.Now.ToString("HH:mm tt")));
        doc.Add(linebreak);
        if(SceneManager.GetActiveScene().name == "ModelScene"){
            doc.Add(TextUnderBlueprint);
            doc.Add(blueprintImg);
            if(File.Exists(Application.streamingAssetsPath + "/FileforPDF/3DBlueprint.png")){    
                doc.Add(TextUnder3D);
                doc.Add(blueprint3DImg);
            }
        } else {
            doc.Add(TextUnderAR);
            doc.Add(ARImg);
        }
        doc.Add(sugg);
        doc.Add(new Paragraph("\nHouse"));
        doc.Add(houseImg);
        doc.Add(new Paragraph(string.Format("\nDescription: {0}\nType: {1}\nRoof: {2}\nMaterial: {3}\n\n", 
        "The final 10% is for accommodation and other purposes (paths, levees, haystacks, space for drying compost, sheds, for mushroom culture, animal pens, flower and ornamental plants, and a kitchen garden).",
        house.type,	house.roof, house.material)));
        doc.Add(new Paragraph("Tree"));
        doc.Add(treeImg);
        doc.Add(new Paragraph(string.Format("\nDescription: {0}\nSpecies: {1}     Pricce: {2}\nSpecies: {3}    Price: {4}\n\n", 
        "The third 30% is used to grow field crops and orchard trees (fruit trees, perennial trees, trees whose wood can be used for general purposes, for firewood, or for construction, field crops, vegetables, and herbs).",
        tree[0].species, tree[0].price, tree[1].species, tree[1].price)));
        doc.Add(new Paragraph("Rice Field"));
        doc.Add(riceImg);
        doc.Add(new Paragraph(string.Format("\nDescription: {0}\nSpecies: {1}     Pricce: {2}\nSpecies: {3}    Price: {4}\n\n", 
        "The second 30% is used for rice farming.", rice[0].species, rice[0].price, rice[1].species, rice[1].price)));
        doc.Add(new Paragraph("Pond")); 
        doc.Add(pondImg);
        doc.Add(new Paragraph(string.Format("\nDescription: {0}\nSpecies: {1}     Pricce: {2}\nSpecies: {3}    Price: {4}\n\n", 
        "The first 30% is used to dig a pond (where fish can be raised and aquatic plants such as morning glory can be grown). Above the pond chicken coops can be built and along the banks of the pond perennial trees that do not need much water to subsist can also be grown.",
        pond[0].species, pond[0].price, pond[1].species, pond[1].price)));       
        doc.Add(linebreak);
        Paragraph EndText = new Paragraph("Hope you have a good project <3");
        EndText.Alignment = Element.ALIGN_CENTER;  
        doc.Add(EndText);
        doc.Close();
        yield return new WaitForEndOfFrame();
    }
}
        

