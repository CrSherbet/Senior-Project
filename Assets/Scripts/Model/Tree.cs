public class Tree {
  public string species { get; set; }
  public string region { get; set; }
  public float price { get; set; }

  public Tree () {
    species = "Banana";
    region = "Central";
    price = 50.0f;
  }

  public Tree (string inputSpecies, string inputRegion, float inputPrice) {
    species = inputSpecies;
    region = inputRegion;
    price = inputPrice;
  }
}


