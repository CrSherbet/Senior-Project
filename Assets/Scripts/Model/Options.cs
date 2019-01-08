public class Options {
  public int region { get; set; }
  public bool house { get; set; }
  public bool pond { get; set; }
  public bool rice { get; set; }
  public bool tree { get; set; }

  public Options () {
    region = 0;
    house = true;
    pond = true;
    rice = true;
    tree = true;
  }  
  
  public Options ( int inputRegion, bool inputHouse, bool inputPond, bool inputRice, bool inputTree) {
    region = inputRegion;
    house = inputHouse;
    pond = inputPond;
    rice = inputRice;
    tree = inputTree;
  }  

} 