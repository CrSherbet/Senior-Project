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

    public RiceField[] getRice () {
		if(Controller.options.rice == true) {
			return new RiceField[3] { new RiceField("Thai jasmine rice", 33.0f), new RiceField("Pathum rice", 18.0f), new RiceField("White rice", 11.7f) };
		} else { return null; }
	}
}