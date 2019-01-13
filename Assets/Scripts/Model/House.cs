public class House {
  public string region { get; set; }

  public House () {
    region = "Central";
  }  
  
  public House (string inputRegion) {
    region = inputRegion;
  }

  public House getHouse (Options options) {
		if(options.house == true) {	
			if(options.regionName == "Central") {
				return new House("Serene house");
			} else if(options.regionName == "Northern") {
				return new House ("Entirely house");
			} else if(options.regionName == "Southern") {
				return new House("High roof");
			} else if(options.regionName == "Eastern") {
				return new House("Serene house");
			} else if(options.regionName == "Western") {
				return new House("Serene house");
			} else {
				return new House("High cellar");
			} 
		} else { return null; }
	}

}