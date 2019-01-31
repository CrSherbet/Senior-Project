using UnityEngine;

public class Model {
    public string Id { get; }
    public string name { get; set; }
    public float size { get; set; }
    public Pond[] pond { get; set; }
    public Tree[] tree { get; set; }
    public RiceField[] rice { get; set; }
    public House house { get; set; }
    public Vector3[] linePos {get; set;}

    public Model (string inputID, string inputName, float inputAreaSize, Vector3[] inputLinePos,
        Pond[] inputPond, Tree[] inputTree, RiceField[] inputRice, House inputHouse) {
        Id = inputID;
        name = inputName;
        size = inputAreaSize;
        linePos = inputLinePos;
        pond = inputPond;
        tree = inputTree;
        rice = inputRice;
        house = inputHouse;
    }
}


