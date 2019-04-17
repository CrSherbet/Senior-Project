using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model3DController : MonoBehaviour {

    public Transform RiceModel;
		public Transform HouseModel;
		public Transform PondModel;
		public Transform TreeModel;

		void Start () {
    		MeshFilter mf = GetComponent<MeshFilter>();
        Mesh mesh = new Mesh();
        mf.mesh = mesh;
    
        List<Vector3> tempPos = Controller.currModel.areaPos.GetRange(0, Controller.currModel.areaPos.Count-1);
        mesh.vertices = tempPos.ToArray();

        // triangle in model
        int[] tri = new int[6];
        tri[0] = 0;
        tri[1] = 1;
        tri[2] = 2;
        tri[3] = 2;
        tri[4] = 3;
        tri[5] = 0;
          
        mesh.triangles = tri;
    
        Vector3[] normals = new Vector3[Controller.currModel.areaPos.Count-1];
        for( int i=0; i<Controller.currModel.areaPos.Count-1; i++){
            normals[i] = -Vector3.forward;
        }    
        mesh.normals = normals;
    
        Vector2[] uv = new Vector2[4];
        uv[0] = new Vector2(0, 0);
        uv[1] = new Vector2(1, 0);
        uv[2] = new Vector2(0, 1);
        uv[3] = new Vector2(1, 1);
        mesh.uv = uv;

        RiceModel = GameObject.Find("RiceModel2").GetComponent<Transform>();
				PondModel = GameObject.Find("PondModel2").GetComponent<Transform>();
				HouseModel = GameObject.Find("HouseModel2").GetComponent<Transform>();
				TreeModel = GameObject.Find("TreeModel2").GetComponent<Transform>();

        RiceModel.position = Controller.currModel.riceArea.center;
				HouseModel.position = Controller.currModel.houseArea.center;
				PondModel.position = Controller.currModel.pondArea.center;
				TreeModel.position = Controller.currModel.treeArea.center;
    }
		
		void Update () {
      
		}
}


