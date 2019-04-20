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
				Debug.Log(Controller.currModel.riceArea.center);
				RiceModel.GetComponent<Transform>().position = Controller.currModel.riceArea.center;
				HouseModel.GetComponent<Transform>().position = Controller.currModel.houseArea.center;
				PondModel.GetComponent<Transform>().position = Controller.currModel.pondArea.center;
				TreeModel.GetComponent<Transform>().position = Controller.currModel.treeArea.center;
		}
		
		void Update () {
		}
}
