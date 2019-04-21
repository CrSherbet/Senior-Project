using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class ModelController : MonoBehaviour {
		
		public Transform RiceModel;
		public Transform HouseModel;
		public Transform PondModel;
		public Transform TreeModel;

		void Start () {
				LineRenderer lineRenderer = GetComponent<LineRenderer>();
				List<Vector3> areaPos = Controller.currModel.dividedAreaPos;

				lineRenderer.positionCount = areaPos.Count;
	
				for (int i = 0; i < areaPos.Count; i++) {
						lineRenderer.SetPosition(i, areaPos[i]);
				}
				if(Controller.options.house){
						HouseModel.GetComponent<Transform>().position = Controller.currModel.houseArea.center;
				}
				if(Controller.options.rice){
						RiceModel.GetComponent<Transform>().position = Controller.currModel.riceArea.center;
				}
				if(Controller.options.pond){
						PondModel.GetComponent<Transform>().position = Controller.currModel.pondArea.center;
				}
				if(Controller.options.tree){
						TreeModel.GetComponent<Transform>().position = Controller.currModel.treeArea.center;
				}
				GameObject.Find("TextArea").GetComponent<Transform>().localScale = new Vector3(3, 3, 3);
				GameObject.Find("TextArea").GetComponent<Transform>().localPosition = new Vector3(-667, 650, 0);
		}
		
		void Update () {
		}
}
