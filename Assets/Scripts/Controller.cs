using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller {

    private House house = new House();
    private Tree tree = new Tree();
    private RiceField rice = new RiceField();
    private Pond pond = new Pond();

    public static Options options = new Options();

    public static Model currModel;

    private Vector3[] SquarePos = new Vector3[5] { new Vector3(50.0f, 300.0f, 0.0f), 
                                    new Vector3(50.0f, 530.0f, 0.0f),
                                    new Vector3(300.0f, 530.0f, 0.0f),
                                    new Vector3(300.0f, 300.0f, 0.0f),
                                    new Vector3(50.0f, 300.0f, 0.0f) };
    private Vector3[] TrianglePos = new Vector3[4] { new Vector3(50.0f, 300.0f, 0.0f), 
                                    new Vector3(175.0f, 530.0f, 0.0f),
                                    new Vector3(300.0f, 300.0f, 0.0f),
                                    new Vector3(50.0f, 300.0f, 0.0f) };
    private Vector3[] RectanglePos = new Vector3[5] { new Vector3(50.0f, 350.0f, 0.0f), 
                                    new Vector3(50.0f, 500.0f, 0.0f),
                                    new Vector3(300.0f, 500.0f, 0.0f),
                                    new Vector3(300.0f, 350.0f, 0.0f),
                                    new Vector3(50.0f, 350.0f, 0.0f) };
    private Vector3[] PentagonPos = new Vector3[6] { new Vector3(50.0f, 380.0f, 0.0f), 
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
            currModel = new Model("9994", "Square", 4.0f, SquarePos, pond.getPond(), 
            tree.getTree(), rice.getRice(), house.getHouse());
        } else if(modelId == "9993") {
            currModel = new Model("9993", "Triangle", 4.0f, TrianglePos, pond.getPond(), 
            tree.getTree(), rice.getRice(), house.getHouse());
        } else if(modelId == "9995") {
            currModel = new Model("9995", "Pentagon", 4.0f, PentagonPos, pond.getPond(), 
            tree.getTree(), rice.getRice(), house.getHouse());
        } else if(modelId == "9991") {
            currModel = new Model("9991", "Rectangle", 4.0f, RectanglePos, pond.getPond(), 
            tree.getTree(), rice.getRice(), house.getHouse());
        } else {
            currModel = new Model("9997", "Polygon", 4.0f, SquarePos, pond.getPond(), 
            tree.getTree(), rice.getRice(), house.getHouse());
        }
    }
}
