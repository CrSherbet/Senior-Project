public class House {
  public string region { get; set; }

  public House () {
    region = "Central";
  }  
  
  public House (string inputRegion) {
    region = inputRegion;
  }

   public House getCHouse () {
    House HouseArr = new House("Serene house");
    return HouseArr;
  }

  public House getNHouse () {
    House HouseType = new House("Entirely house");
    return HouseType;
  }

  public House getSHouse () {
    House HouseType = new House("High roof");
    return HouseType;
  } 

  public House getEHouse () {
    House HouseType = new House("Serene house");
    return HouseType;
  }

  public House getWHouse () {
    House HouseType = new House("Serene house");
    return HouseType;
  }

  public House getNEHouse () {
    House HouseType = new House("High cellar");
    return HouseType;
  }

} 