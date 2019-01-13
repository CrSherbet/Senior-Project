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

  	public Pond[] getPond () {
		if(Controller.options.pond == true) {
			return new Pond[3] { new Pond("Shrimp", 290.0f), new Pond("Snapper", 200.0f), new Pond("Carp", 35.0f) };
		} else { return null; }
	}
}