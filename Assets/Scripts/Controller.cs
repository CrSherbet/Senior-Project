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

    void Start () {
	
    }
	
    void Update () {
		
    }

    public void CalculateArea (string modelId) {
        if(modelId == "9994") {
            currModel = new Model("9994", "Square", 4.0f, pond.getPond(), 
            tree.getTree(), rice.getRice(), house.getHouse());
        } else if(modelId == "9993") {
            currModel = new Model("9993", "Triangle", 4.0f, pond.getPond(), 
            tree.getTree(), rice.getRice(), house.getHouse());
        } else if(modelId == "9995") {
            currModel = new Model("9995", "Pentagon", 4.0f, pond.getPond(), 
            tree.getTree(), rice.getRice(), house.getHouse());
        } else if(modelId == "9991") {
            currModel = new Model("9991", "Rectangle", 4.0f, pond.getPond(), 
            tree.getTree(), rice.getRice(), house.getHouse());
        } else {
            currModel = new Model("9994", "Square", 4.0f, pond.getPond(), 
            tree.getTree(), rice.getRice(), house.getHouse());
        }
    }
}
