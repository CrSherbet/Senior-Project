using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller {
    public static Options options = new Options();
    public static Area area = new Area();
    public static Model currModel;

    private List<Vector3> SquarePos = new List<Vector3> { new Vector3(50.0f, 300.0f, 0.0f), 
                                    new Vector3(50.0f, 530.0f, 0.0f),
                                    new Vector3(300.0f, 530.0f, 0.0f),
                                    new Vector3(300.0f, 300.0f, 0.0f),
                                    new Vector3(50.0f, 300.0f, 0.0f) };
    private List<Vector3> TrianglePos = new List<Vector3> { new Vector3(50.0f, 300.0f, 0.0f), 
                                    new Vector3(175.0f, 530.0f, 0.0f),
                                    new Vector3(300.0f, 300.0f, 0.0f),
                                    new Vector3(50.0f, 300.0f, 0.0f) };
    private List<Vector3> RectanglePos = new List<Vector3> { new Vector3(50.0f, 350.0f, 0.0f), 
                                    new Vector3(50.0f, 500.0f, 0.0f),
                                    new Vector3(300.0f, 500.0f, 0.0f),
                                    new Vector3(300.0f, 350.0f, 0.0f),
                                    new Vector3(50.0f, 350.0f, 0.0f) };
    private List<Vector3> PentagonPos = new List<Vector3> { new Vector3(50.0f, 380.0f, 0.0f), 
                                    new Vector3(100.0f, 530.0f, 0.0f),
                                    new Vector3(250.0f, 490.0f, 0.0f),
                                    new Vector3(280.0f, 380.0f, 0.0f),
                                    new Vector3(165.0f, 280.0f, 0.0f),
                                    new Vector3(50.0f, 380.0f, 0.0f) };

    void Start () {
	
    }
	
    void Update () {
		
    }

    public void CalculateArea (string modelId) {
        if(modelId == "9994") {
            currModel = new Model("9994", "Square", SquarePos);
        } else if(modelId == "9993") {
            currModel = new Model("9993", "Triangle", TrianglePos);
        } else if(modelId == "9995") {
            currModel = new Model("9995", "Pentagon", PentagonPos);
        } else if(modelId == "9991") {
            currModel = new Model("9991", "Rectangle", RectanglePos);
        } else {
            currModel = new Model("9997", "Polygon", SquarePos);
        }
    }

}
