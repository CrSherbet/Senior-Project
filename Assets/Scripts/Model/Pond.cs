public class Pond {
  public string species { get; set; }
  public float price { get; set; }

  public Pond () {
    species = "Tilapia";
    price = 40.0f;
  }

  public Pond (string inputSpecies, float inputPrice) {
    species = inputSpecies;
    price = inputPrice;
  }
}