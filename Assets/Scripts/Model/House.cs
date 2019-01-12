public class House {
  public string region { get; set; }

  public House () {
    region = "Central";
  }  
  
  public House (string inputRegion) {
    region = inputRegion;
  }

  public House getHouse (string regionName, bool isHouse) {
		if(isHouse == true) {	
			if(regionName == "Central") {
				return new House("Serene house");
			} else if(regionName == "Northern") {
				return new House ("Entirely house");
			} else if(regionName == "Southern") {
				return new House("High roof");
			} else if(regionName == "Eastern") {
				return new House("Serene house");
			} else if(regionName == "Western") {
				return new House("Serene house");
			} else {
				return new House("High cellar");
			} 
		} else { return null; }
	}

}