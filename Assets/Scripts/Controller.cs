using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller {

	private Tree TreeArr;
	private Pond PondArr;
	private RiceField RiceArr;
	private House HouseType;

	private House house;
	private Tree[] tree;

	// private Model SquareModel = new Model ("9991", "Square", 4.0f);
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
		currModel = new Model("9991", "Square", 4.0f, getPond(), getTree(), getRice(), getHouse());
	}

	House getHouse () {
		if(options.house == true) {	
			if(options.regionName == "Central") {
				house = HouseType.getCHouse();
			} else if(options.regionName == "Northern") {
				house = HouseType.getNHouse();
			} else if(options.regionName == "Southern") {
				house = HouseType.getSHouse();
			} else if(options.regionName == "Eastern") {
				house = HouseType.getEHouse();
			} else if(options.regionName == "Western") {
				house = HouseType.getWHouse();
			} else if(options.regionName == "Northeastern") {
				house = HouseType.getNEHouse();
			} 
		} else { house = null; }
		return house;
	}

	Tree[] getTree () {
		if(options.tree == true) {	
			if(options.regionName == "Central") {
				tree = TreeArr.getCTree();
			} else if(options.regionName == "Northern") {
				tree = TreeArr.getNTree();
			} else if(options.regionName == "Southern") {
				tree = TreeArr.getSTree();
			} else if(options.regionName == "Eastern") {
				tree = TreeArr.getETree();
			} else if(options.regionName == "Western") {
				tree = TreeArr.getWTree();
			} else if(options.regionName == "Northeastern") {
				tree = TreeArr.getNETree();
			} 
		} else { tree = null; }
		return tree;
	}

	RiceField[] getRice () {
		if(options.rice == true) {
			return RiceArr.getRice();
		} else { return null; }
	}

	Pond[] getPond () {
		if(options.pond == true) {
			return PondArr.getPonds();
		} else { return null; }
	}

}
