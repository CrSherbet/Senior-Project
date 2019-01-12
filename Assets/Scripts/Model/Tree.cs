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

  public Tree[] getCTree () {
    Tree[] TreeArr = { new Tree("Mango", "Central", 53.50f), new Tree("rambutan", "Central", 43.0f) };
    return TreeArr;
  }

  public Tree[] getNTree () {
    Tree[] TreeArr = { new Tree("Strawberry", "Northern", 150.0f), new Tree("Garlic", "North", 90.0f) };
    return TreeArr;
  }

  public Tree[] getSTree () {
    Tree[] TreeArr = { new Tree("Rubber", "Southern", 38.93f), new Tree("Palm", "South", 2.67f) };
    return TreeArr;
  } 

  public Tree[] getETree () {
    Tree[] TreeArr = { new Tree("Durian", "Eastern", 110.0f), new Tree("Mangosteen",  "Eastern", 20.0f) };
    return TreeArr;
  }

  public Tree[] getWTree () {
    Tree[] TreeArr = { new Tree("Potato", "Western", 2.92f), new Tree("Pineapple", "Western", 22.50f) };
    return TreeArr;
  }

  public Tree[] getNETree () {
    Tree[] TreeArr = { new Tree("Corn", "Northeastern", 9.89f), new Tree("Cane", "Northeastern", 0.63f) };
    return TreeArr;
  }

}


