using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model3DController : MonoBehaviour {

    public Transform RiceModel;
		public Transform HouseModel;
		public Transform PondModel;
		public Transform TreeModel;
    public static Quaternion originalRotationValue; 
    Transform Model3D;

		void Start () {
				RiceModel.GetComponent<Transform>().position = Controller.currModel.riceArea.center;
				HouseModel.GetComponent<Transform>().position = Controller.currModel.houseArea.center;
				PondModel.GetComponent<Transform>().position = Controller.currModel.pondArea.center;
				TreeModel.GetComponent<Transform>().position = Controller.currModel.treeArea.center;

    		MeshFilter mf = GetComponent<MeshFilter>();
        Mesh mesh = new Mesh();
        mf.mesh = mesh;
    
        List<Vector3> tempPos = Controller.currModel.areaPos.GetRange(0, Controller.currModel.areaPos.Count-1);
        mesh.vertices = tempPos.ToArray();

        Vector3[] normals = new Vector3[Controller.currModel.areaPos.Count-1];
        for( int i=0; i<Controller.currModel.areaPos.Count-1; i++){
            normals[i] = -Vector3.forward;
        }    
        mesh.normals = normals;
        if(Controller.currModel.Id == "9994" || Controller.currModel.Id == "9991"){
            mesh.triangles = new int[]{0, 1, 2, 2, 3, 0};    

            Vector2[] uv = new Vector2[4];
            uv[0] = new Vector2(0, 0);
            uv[1] = new Vector2(1, 0);
            uv[2] = new Vector2(0, 1);
            uv[3] = new Vector2(1, 1);
            mesh.uv = uv;
        } else if (Controller.currModel.Id == "9993") {
            mesh.triangles = new int[]{0, 1, 2};
    
            Vector2[] uv = new Vector2[3];
            uv[0] = new Vector2(0, 0);
            uv[1] = new Vector2(1, 0);
            uv[2] = new Vector2(0, 1);
            mesh.uv = uv;
        } else if (Controller.currModel.Id == "9995") {
            mesh.triangles = new int[]{0, 1, 2, 2, 4, 0, 2, 3, 4};
    
            Vector2[] uv = new Vector2[5];
            uv[0] = new Vector2(0, 0);
            uv[1] = new Vector2(1, 0);
            uv[2] = new Vector2(0, 1);
            uv[3] = new Vector2(1, 1);
            uv[4] = new Vector2(1, 1);
            mesh.uv = uv;
        }

        Model3D = GameObject.Find("Group3DBP").GetComponent<Transform>();
        Model3D.localPosition = new Vector3(-80f, 400f, -420f);
        Model3D.Rotate(45f, 0f, -159.854f);
        Model3D.localScale = new Vector3(0.7f, 0.7f, 0.7f);
        originalRotationValue = Model3D.rotation;
    }
		
		void Update () {
      
		}
}


