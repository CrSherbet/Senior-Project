using UnityEngine;
using System.Collections.Generic;

public class Model {
    public string Id { get; }
    public string name { get; set; }
    public Area pondArea { get; set; }
    public Area treeArea { get; set; }
    public Area riceArea { get; set; }
    public Area houseArea { get; set; }
    public List<Vector3> areaPos {get; set;}
    public List<Vector3> dividedAreaPos {get; set;}
    
		// private BoxCollider2D collider;

    public Model (string inputID, List<Vector3> inputAreaPos) {
        Id = inputID;
        name = "ARShapeModel";
        areaPos = inputAreaPos;
        dividedAreaPos = allocateArea();
    }

    public Model (string inputID, string inputName, List<Vector3> inputAreaPos) {
        Id = inputID;
        name = inputName;
        areaPos = inputAreaPos;
        dividedAreaPos = allocateArea();
    }

    public List<Vector3> allocateArea(){
        //calculate and allocate the area, then get position of house, pond, rice field, and tree
        houseArea = new Area("House", new List<Vector3> {new Vector3(50.0f, 357.5f, 0.0f), 
                                                        new Vector3(150.0f, 357.5f, 0.0f),
                                                        new Vector3(150.0f, 300.0f, 0.0f),
                                                        new Vector3(50.0f, 300.0f, 0.0f),
                                                        new Vector3(50.0f, 357.5f, 0.0f) });
        pondArea = new Area("Pond", new List<Vector3> {new Vector3(150.0f, 357.5f, 0.0f),
                                                        new Vector3(150.0f, 530.0f, 0.0f),
                                                        new Vector3(50.0f, 530.0f, 0.0f),
                                                        new Vector3(50.0f, 357.5f, 0.0f), 
                                                        new Vector3(150.0f, 357.5f, 0.0f) });
        riceArea = new Area("Rice", new List<Vector3> {new Vector3(150.0f, 415.0f, 0.0f), 
                                                        new Vector3(150.0f, 530.0f, 0.0f),
                                                        new Vector3(300.0f, 530.0f, 0.0f),
                                                        new Vector3(300.0f, 415.0f, 0.0f),
                                                        new Vector3(150.0f, 415.0f, 0.0f)});
        treeArea = new Area("Tree", new List<Vector3> {new Vector3(150.0f, 300.0f, 0.0f), 
                                                        new Vector3(300.0f, 300.0f, 0.0f),
                                                        new Vector3(300.0f, 415.0f, 0.0f),
                                                        new Vector3(150.0f, 415.0f, 0.0f),
                                                        new Vector3(150.0f, 300.0f, 0.0f) });
        // houseArea = new Area("House", housePos);
        // pondArea = new Area("Pond", pondPos);
        // riceArea = new Area("Rice", ricePos);
        // treeArea = new Area("Tree", treePos);
        
        List<Vector3> dividedPos = new List<Vector3>();
        dividedPos.AddRange(houseArea.areaPos);
        dividedPos.AddRange(pondArea.areaPos);
        dividedPos.AddRange(riceArea.areaPos);
        dividedPos.AddRange(treeArea.areaPos);
        return dividedPos;
    }

    
		// public Vector3 findPointInArea() {
		// 		collider = GetComponent<BoxCollider2D>();
		// 		var bounds = collider.bounds;
		// 		var center = bounds.center;
			
		// 		float x = 0;
		// 		float y = 0;
		// 		do {
		// 			x = UnityEngine.Random.Range(center.x - bounds.extents.x, center.x + bounds.extents.x);
		// 			y = UnityEngine.Random.Range(center.y - bounds.extents.y, center.y + bounds.extents.y);
		// 		} while (Physics2D.OverlapPoint(new Vector2(x, y), LayerMask.NameToLayer("Area")) == null);
		// 		Debug.Log("X" + x);
		// 		Debug.Log("Y" + y);
		// 		return new Vector3(x, y, 0);
		// }
}


