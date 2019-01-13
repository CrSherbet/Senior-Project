public class Model {
    public string id { get; }
    public string name { get; set; }
    public float size { get; set; }
    public Pond[] pond { get; set; }
    public Tree[] tree { get; set; }
    public RiceField[] rice { get; set; }
    public House house { get; set; }

    public Model (string inputID, string inputName, float inputAreaSize) {
      id = inputID;
      name = inputName;
      size = inputAreaSize;
      // pond = new Pond[1];
      // tree = new Tree[1];
      // rice = new RiceField[1];
      // house = new House();
    }

    public Model (string inputID, string inputName, float inputAreaSize,
     Pond[] inputPond, Tree[] inputTree, RiceField[] inputRice, House inputHouse) {
      id = inputID;
      name = inputName;
      size = inputAreaSize;
      pond = inputPond;
      tree = inputTree;
      rice = inputRice;
      house = inputHouse;
    }
}


