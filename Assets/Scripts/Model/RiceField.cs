public class RiceField {
  public string species { get; set; }
  public float price { get; set; }

  public RiceField () {
    species = "Thai Jasmine";
    price = 15.0f;
  }

  public RiceField (string inputSpecies, float inputPrice) {
    species = inputSpecies;
    price = inputPrice;
  }
}