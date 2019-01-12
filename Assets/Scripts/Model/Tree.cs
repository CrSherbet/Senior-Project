public class Tree {
  public string species { get; set; }
  public string region { get; set; }
  public float price { get; set; }

  private Tree[] CTree = { new Tree("Mango", "Central", 53.50f), new Tree("rambutan", "Central", 43.0f) };
  private Tree[] NTree = { new Tree("Strawberry", "Northern", 150.0f), new Tree("Garlic", "North", 90.0f) };
  private Tree[] STree = { new Tree("Rubber", "Southern", 38.93f), new Tree("Palm", "South", 2.67f) };
  private Tree[] ETree = { new Tree("Durian", "Eastern", 110.0f), new Tree("Mangosteen",  "Eastern", 20.0f) };
  private Tree[] WTree = { new Tree("Potato", "Western", 2.92f), new Tree("Pineapple", "Western", 22.50f) };
  private Tree[] NETree = { new Tree("Corn", "Northeastern", 9.89f), new Tree("Cane", "Northeastern", 0.63f) };

  private Tree[] treeArr;
  public static Options options = new Options();



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

  public Tree[] getTree () {
		if(options.tree == true) {	
			if(options.regionName == "Central") {
				treeArr = CTree;
			} else if(options.regionName == "Northern") {
				treeArr = NTree;
			} else if(options.regionName == "Southern") {
				treeArr = STree;
			} else if(options.regionName == "Eastern") {
				treeArr = ETree;
			} else if(options.regionName == "Western") {
				treeArr = WTree;
			} else if(options.regionName == "Northeastern") {
				treeArr = NETree;
			} 
		} else { treeArr = null; }
		return treeArr;
	}

}


