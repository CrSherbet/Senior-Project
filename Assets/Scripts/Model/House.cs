public class House {
  public string region { get; set; }

  private House CHouse = new House("Serene house");
  private House  NHouse = new House ("Entirely house");
  private House SHouse = new House("High roof");
  private House EHouse = new House("Serene house");
  private House WHouse = new House("Serene house"); 
  private House NEHouse = new House("High cellar");
  private House house;
  public static Options options = new Options();


  public House () {
    region = "Central";
  }  
  
  public House (string inputRegion) {
    region = inputRegion;
  }

  public House getHouse () {
		if(options.house == true) {	
			if(options.regionName == "Central") {
				house = CHouse;
			} else if(options.regionName == "Northern") {
				house = NHouse;
			} else if(options.regionName == "Southern") {
				house = SHouse;
			} else if(options.regionName == "Eastern") {
				house = EHouse;
			} else if(options.regionName == "Western") {
				house = WHouse;
			} else if(options.regionName == "Northeastern") {
				house = NEHouse;
			} 
		} else { house = null; }
		return house;
	}

}