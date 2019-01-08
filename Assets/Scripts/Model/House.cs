public class House {
  public string region { get; set; }

  public House () {
    region = "Central";
  }  
  
  public House (string inputRegion) {
    region = inputRegion;
  }

} 