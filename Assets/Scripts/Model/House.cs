public class House {
  public string region { get; set; }

  public House () {
    region = "Central";
  }  
  
  public House (string inputRegion) {
    region = inputRegion;
  }

  public House getHouse () {
		if(Controller.options.house == true) {	
			if(Controller.options.regionName == "Central") {
				return new House("Serene house");
			} else if(Controller.options.regionName == "Northern") {
				return new House ("Entirely house");
			} else if(Controller.options.regionName == "Southern") {
				return new House("High roof");
			} else if(Controller.options.regionName == "Eastern") {
				return new House("Serene house");
			} else if(Controller.options.regionName == "Western") {
				return new House("Serene house");
			} else {
				return new House("High cellar");
			} 
		} else { return null; }
	}

}