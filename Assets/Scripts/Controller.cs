using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

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

	void CalculateArea () {
		currModel = new Model("9991", "Square", 4.0f, getPond(), getTree(), getRice(), getHouse());
	}

	House getHouse () {
		if(options.house == true) {	
			if(options.region == 0) {
				house = HouseType.getCHouse();
			} else if(options.region == 1) {
				house = HouseType.getNHouse();
			} else if(options.region == 2) {
				house = HouseType.getSHouse();
			} else if(options.region == 3) {
				house = HouseType.getEHouse();
			} else if(options.region == 4) {
				house = HouseType.getWHouse();
			} else if(options.region == 5) {
				house = HouseType.getNEHouse();
			} 
		} else { house = null; }
		return house;
	}

	Tree[] getTree () {
		if(options.tree == true) {	
			if(options.region == 0) {
				tree = TreeArr.getCTree();
			} else if(options.region == 1) {
				tree = TreeArr.getNTree();
			} else if(options.region == 2) {
				tree = TreeArr.getSTree();
			} else if(options.region == 3) {
				tree = TreeArr.getETree();
			} else if(options.region == 4) {
				tree = TreeArr.getWTree();
			} else if(options.region == 5) {
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
