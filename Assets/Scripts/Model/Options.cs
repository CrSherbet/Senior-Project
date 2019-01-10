public class Options {
  public int region { get; set; }
  public string regionName { get; set; }
  public bool house { get; set; }
  public bool pond { get; set; }
  public bool rice { get; set; }
  public bool tree { get; set; }

  public Options () {
    region = 0;
    regionName = "Central";
    house = true;
    pond = true;
    rice = true;
    tree = true;
  }  
  
  public Options ( int inputRegion, string inputRegionName, bool inputHouse, bool inputPond, bool inputRice, bool inputTree) {
    region = inputRegion;
    regionName = inputRegionName;
    house = inputHouse;
    pond = inputPond;
    rice = inputRice;
    tree = inputTree;
  }  

} 