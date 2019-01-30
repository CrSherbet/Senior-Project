public class House {
	public string region { get; set; }

	public House () {
		region = "Central";
    }  
		
	public House (string inputRegion) {
		region = inputRegion;
	}

	public House[] getHouse () {
			if(Controller.options.house == true) {	
			if(Controller.options.regionName == "Central") {
				return new House[3] { new House("Elevated"), new House("Serene"), new House("Wide terrace") };
      } else if(Controller.options.regionName == "Northern") {
				return new House[3] { new House("Elevated"), new House("Narrow window"), new House("Dense") };
			} else if(Controller.options.regionName == "Southern") {
				return new House[3] { new House("Provisional"), new House("Elevated"), new House("Made from bamboo") };
			} else if(Controller.options.regionName == "Eastern") {
				return new House[3] { new House("Elevated"), new House("Serene"), new House("Made from bamboo") };
			} else if(Controller.options.regionName == "Western") {
				return new House[3] { new House("Serene"), new House("Elevate"), new House("Gable roof") };
			} else {
				return new House[3] { new House("Connecting terrace"), new House("Gable House"), new House("Made from wood") };
      } 
		} else { return null; }
	}
}