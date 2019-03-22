using UnityEngine;

public class Pond {
    public string species { get; set; }
    public float price { get; set; }

    public Pond () {
        species = "Tilapia";
        price = 40.0f;
    }

    public Pond (string inputSpecies, float inputPrice) {
        species = inputSpecies;
        price = inputPrice;
    }

  	public Pond[] getPond () {
		if(Controller.options.pond == true) {
            if(Controller.options.regionName == "Central") {
				return new Pond[3] { new Pond("Shrimp", 550.0f), new Pond("Snakehead", 110.0f), new Pond("Catfish", 53.75f) };
            } else if(Controller.options.regionName == "Northern") {
				return new Pond[3] { new Pond("Diary cattle", 18.25f), new Pond("Pig", 66.3f), new Pond("Chicken", 33.0f) };
			} else if(Controller.options.regionName == "Southern") {
				return new Pond[3] { new Pond("Goat", 121.51f), new Pond("King mackerel", 132.29f), new Pond("White pomfre", 600.0f) };
			} else if(Controller.options.regionName == "Eastern") {
				return new Pond[3] { new Pond("Pig", 66.3f), new Pond("Beef cattle", 92.42f), new Pond("Diary cattle", 18.25f) };
			} else if(Controller.options.regionName == "Western") {
				return new Pond[3] { new Pond("Goat", 121.51f), new Pond("Pig", 66.3f), new Pond("Chicken", 33.0f) };
			} else {
				return new Pond[3] { new Pond("Buffalo", 97.18f), new Pond("Pig", 66.3f), new Pond("Beef cattle", 92.42f) };
            } 
		} else { return null; }
	}

	public Vector3[] getArea() {
		if(Controller.options.pond == true) {
			return new Vector3[5] { 
				new Vector3(150.0f, 357.5f, 0.0f),
				new Vector3(150.0f, 530.0f, 0.0f),
				new Vector3(50.0f, 530.0f, 0.0f),
				new Vector3(50.0f, 357.5f, 0.0f), 
				new Vector3(150.0f, 357.5f, 0.0f) };
		} else { return null; }
	}
}