public class Pond {
  public string species { get; set; }
  public float price { get; set; }

  private Pond[] pond = { new Pond("Shrimp", 290.0f), new Pond("Snapper", 200.0f), new Pond("Carp", 35.0f) };
  public static Options options = new Options();


  public Pond () {
    species = "Tilapia";
    price = 40.0f;
  }

  public Pond (string inputSpecies, float inputPrice) {
    species = inputSpecies;
    price = inputPrice;
  }

  	public Pond[] getPond () {
		if(options.pond == true) {
			return pond;
		} else { return null; }
	}
}