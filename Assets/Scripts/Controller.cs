using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller {

	private Model SquareModel = new Model ("9991", "Square", 4.0f);
	// private Model TriangleModel = new Model ("9992", "Triangle", 5.5f);
	// private Model PentagonModel = new Model ("9993", "Pentagon", 8.2f);
	// private Model TrapezoidModel = new Model ("9994", "Trapezoid", 8.2f);
	public static Options options = new Options();
	public static Model currModel;
	
	void Start () {
	
	}
	
	void Update () {
		
	}

	public void CalculateArea () {
		currModel = SquareModel;
	}
}
