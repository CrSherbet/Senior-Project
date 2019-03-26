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
				RiceModel = GameObject.Find("RiceModel").GetComponent<Transform>();
				PondModel = GameObject.Find("PondModel").GetComponent<Transform>();
				HouseModel = GameObject.Find("HouseModel").GetComponent<Transform>();
				TreeModel = GameObject.Find("TreeModel").GetComponent<Transform>();
	
				LineRenderer lineRenderer = GetComponent<LineRenderer>();
				List<Vector3> areaPos = Controller.currModel.dividedAreaPos;

				lineRenderer.positionCount = areaPos.Count;
	
				for (int i = 0; i < areaPos.Count; i++) {
						lineRenderer.SetPosition(i, areaPos[i]);
				}
		}
		
		void Update () {
				RiceModel.position = Controller.currModel.riceArea.center;
				HouseModel.position = Controller.currModel.houseArea.center;
				PondModel.position = Controller.currModel.pondArea.center;
				TreeModel.position = Controller.currModel.treeArea.center;
		}
}
