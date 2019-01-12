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

  public RiceField[] getRice() {
    RiceField[] rice = { new RiceField("Thai jasmine rice", 33.0f), new RiceField("Pathum rice", 18.0f), new RiceField("White rice", 11.7f) };
    return rice;
  }
}