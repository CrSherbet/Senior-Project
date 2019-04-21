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
        if(Controller.options.rice){
            RiceModel.position = Controller.currModel.riceArea.center;
            RiceModel.localScale = new Vector3(RiceModel.localScale.x + Controller.currModel.riceArea.scaleX, 
            RiceModel.localScale.y, RiceModel.localScale.z + Controller.currModel.riceArea.scaleY);
        }

        if(Controller.options.house){
            HouseModel.position = Controller.currModel.houseArea.center;
            HouseModel.localScale = new Vector3(HouseModel.localScale.x , 
            HouseModel.localScale.y, HouseModel.localScale.z);
        }

        if(Controller.options.pond){
            PondModel.position = Controller.currModel.pondArea.center;
            PondModel.localScale = new Vector3(PondModel.localScale.x + Controller.currModel.pondArea.scaleX, 
            PondModel.localScale.y, PondModel.localScale.z + Controller.currModel.pondArea.scaleY);
        }
        
        if(Controller.options.tree){
            TreeModel.position = Controller.currModel.treeArea.center;
            TreeModel.localScale = new Vector3(TreeModel.localScale.x + Controller.currModel.treeArea.scaleX, 
            TreeModel.localScale.y, TreeModel.localScale.z + Controller.currModel.treeArea.scaleX);
        }

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
        Model3D.localPosition = new Vector3(-318f, -185f, -107f);
        Model3D.Rotate(50f, 0f, 45f);
        Model3D.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        originalRotationValue = Model3D.rotation;
    }
		
	void Update () {
      
	}
}


