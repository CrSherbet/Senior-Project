using UnityEngine;

public class House {
		public string roof { get; set; }
		public string material { get; set; }
		public string type { get; set; }

		public House () {
				roof = "Gable roof";
				material = "Wood";
				type = "Serene";
		}  
			
		public House (string inputRoof, string inputMaterial, string inpustType) {
				roof = inputRoof;
				material = inputMaterial;
				type = inpustType;
		}

		public House getHouse () {
				if(Controller.options.house == true) {	
						if(Controller.options.regionName == "Central") {
								return new House("Manila roof", "Wood", "Serene");
						} else if(Controller.options.regionName == "Northern") {
								return new House("Gable roof", "Wood", "Dense");
						} else if(Controller.options.regionName == "Southern") {
								return new House("Gable roof", "Bamboo", "Serene");
						} else if(Controller.options.regionName == "Eastern") {
								return new House("Gable roof", "Bamboo", "Serene");
						} else if(Controller.options.regionName == "Western") {
								return new House("Gable roof", "Wood", "Serene");
						} else {
								return new House("Gable roof", "Wood", "Serene");
						} 
				} else { return null; }
		}

		public Vector3[] getArea() {
			if(Controller.options.house == true) {
				return new Vector3[5] { 
					new Vector3(50.0f, 357.5f, 0.0f), 
					new Vector3(150.0f, 357.5f, 0.0f),
					new Vector3(150.0f, 300.0f, 0.0f),
					new Vector3(50.0f, 300.0f, 0.0f),
					new Vector3(50.0f, 357.5f, 0.0f) };
			} else { return null; }
		}
}