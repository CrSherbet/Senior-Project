using UnityEngine;

public class Tree {
    public string species { get; set; }
    public string region { get; set; }
    public float price { get; set; }

    public Tree () {
        species = "Banana";
        region = "Central";
        price = 50.0f;
    }

    public Tree (string inputSpecies, string inputRegion, float inputPrice) {
        species = inputSpecies;
        region = inputRegion;
        price = inputPrice;
    }

    public Tree[] getTree () {
		if(Controller.options.tree == true) {	
			if(Controller.options.regionName == "Central") {
				return new Tree[2] { new Tree("Mango", "Central", 53.50f), new Tree("rambutan", "Central", 43.0f) };
			} else if(Controller.options.regionName == "Northern") {
				return new Tree[2] { new Tree("Strawberry", "Northern", 150.0f), new Tree("Garlic", "North", 90.0f) };
			} else if(Controller.options.regionName == "Southern") {
				return new Tree[2] { new Tree("Rubber", "Southern", 38.93f), new Tree("Palm", "South", 2.67f) };
			} else if(Controller.options.regionName == "Eastern") {
				return new Tree[2] { new Tree("Durian", "Eastern", 110.0f), new Tree("Mangosteen",  "Eastern", 20.0f) };
			} else if(Controller.options.regionName == "Western") {
				return new Tree[2] { new Tree("Potato", "Western", 2.92f), new Tree("Pineapple", "Western", 22.50f) };
			} else {
				return new Tree[2] { new Tree("Corn", "Northeastern", 9.89f), new Tree("Cane", "Northeastern", 0.63f) };
			} 
		} else { return null; }
	}

	public Vector3[] getArea() {
		if(Controller.options.pond == true) {
			return new Vector3[5] { 
				new Vector3(150.0f, 300.0f, 0.0f), 
				new Vector3(300.0f, 300.0f, 0.0f),
				new Vector3(300.0f, 415.0f, 0.0f),
				new Vector3(150.0f, 415.0f, 0.0f),
				new Vector3(150.0f, 300.0f, 0.0f) };
		} else { return null; }
	}
}


