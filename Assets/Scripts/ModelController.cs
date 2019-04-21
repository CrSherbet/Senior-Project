using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class ModelController : MonoBehaviour {
	
		void Start () {
				LineRenderer lineRenderer = GetComponent<LineRenderer>();
				Transform transform = GetComponent<Transform>();
				List<Vector3> areaPos = new List<Vector3>();
	
				if(transform.name == "PondModel" && Controller.options.pond){
						transform.localPosition = Controller.currModel.pondArea.center;
						areaPos = Controller.currModel.pondArea.areaPos;
				} else if(transform.name == "HouseModel" && Controller.options.house){
						transform.localPosition = Controller.currModel.houseArea.center;
						areaPos = Controller.currModel.houseArea.areaPos;
				} else if(transform.name == "RiceModel" && Controller.options.rice){
						transform.localPosition = Controller.currModel.riceArea.center;
						areaPos = Controller.currModel.riceArea.areaPos;
				} else if(transform.name == "TreeModel" && Controller.options.tree){
						transform.localPosition = Controller.currModel.treeArea.center;
						areaPos = Controller.currModel.treeArea.areaPos;
				} 
				
				lineRenderer.positionCount = areaPos.Count;
	
				for (int i = 0; i < areaPos.Count; i++) {
						lineRenderer.SetPosition(i, areaPos[i]);
				}

				GameObject.Find("Blueprint").GetComponent<Transform>().localScale = new Vector3(2.3f, 2.3f, 2.3f);
				GameObject.Find("Blueprint").GetComponent<Transform>().localPosition = new Vector3(-389, -820, 0);
		}
		
		void Update () {
		}
}
