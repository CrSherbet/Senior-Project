using UnityEngine;

public class RiceField {
    public string species { get; set; }
    public float price { get; set; }

    public RiceField () {
        species = "Thai Jasmine";
        price = 15.0f;
    }

    public RiceField (string inputSpecies, float inputPrice) {
        species = inputSpecies;
        price = inputPrice;
    }

    public RiceField[] getRice () {
		if(Controller.options.rice == true) {
			if(Controller.options.regionName == "Central") {
				return new RiceField[2] { new RiceField("Thai jasmine rice", 16.3f), new RiceField("Pathum rice", 11.1f) };
            } else if(Controller.options.regionName == "Northern") {
				return new RiceField[2] { new RiceField("Thai jasmine rice", 16.3f), new RiceField("Glutinous rice", 12.5f) };
			} else if(Controller.options.regionName == "Southern") {
				return new RiceField[2] { new RiceField("Thai jasmine rice", 16.3f), new RiceField("Riceberry", 25f) };
			} else if(Controller.options.regionName == "Eastern") {
				return new RiceField[2] { new RiceField("Thai jasmine rice", 16.3f), new RiceField("Brown rice", 8.6f) };
			} else if(Controller.options.regionName == "Western") {
				return new RiceField[2] { new RiceField("Thai jasmine rice", 16.3f), new RiceField("Riceberry", 25f) };
			} else {
				return new RiceField[2] { new RiceField("Thai jasmine rice", 16.3f), new RiceField("Glutinous rice", 12.5f) };
            } 
		} else { return null; }
	}

	public Vector3[] getArea() {
		if(Controller.options.rice == true) {
			return new Vector3[5] { 
				new Vector3(150.0f, 415.0f, 0.0f), 
				new Vector3(150.0f, 530.0f, 0.0f),
				new Vector3(300.0f, 530.0f, 0.0f),
				new Vector3(300.0f, 415.0f, 0.0f),
				new Vector3(150.0f, 415.0f, 0.0f) };
		} else { return null; }
	}
}