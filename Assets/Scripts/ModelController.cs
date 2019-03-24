using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class ModelController : MonoBehaviour {

		private BoxCollider2D collider;
		Transform RiceModel;
		Transform HouseModel;
		Transform PondModel;
		Transform TreeModel;

		void Start () {
				RiceModel = GameObject.Find("RiceModel").GetComponent<Transform>();
				PondModel = GameObject.Find("PondModel").GetComponent<Transform>();
				HouseModel = GameObject.Find("HouseModel").GetComponent<Transform>();
				TreeModel = GameObject.Find("TreeModel").GetComponent<Transform>();
	
				LineRenderer lineRenderer = GetComponent<LineRenderer>();
				Vector3[] linePos = Controller.currModel.linePos;
				
				Vector3[] area = Controller.currModel.area;
				
				List<Vector3> result = new List<Vector3>();
				result.AddRange(linePos);
				
				if (area != null) {
					result.AddRange(area);
				} 

				Vector3[] showResult = result.ToArray();

				lineRenderer.positionCount = showResult.Length;
				
				for (int i = 0; i < showResult.Length; i++) {
						lineRenderer.SetPosition(i, showResult[i]);
				}

		}
		
		// Update is called once per frame
		void Update () {
				// RiceModel.position = new Vector3();
				// HouseModel.position = new Vector3();
				// PondModel.position = new Vector3();
				// TreeModel.position = new Vector3();
		}

		//Random point in area [Random X and Y]
		public Vector3 PointInArea() {
				collider = GetComponent<BoxCollider2D>();
				var bounds = collider.bounds;
				var center = bounds.center;
	
				float x = 0;
				float y = 0;
				do {
						x = UnityEngine.Random.Range(center.x - bounds.extents.x, center.x + bounds.extents.x);
						y = UnityEngine.Random.Range(center.y - bounds.extents.y, center.y + bounds.extents.y);
				} while (Physics2D.OverlapPoint(new Vector2(x, y), LayerMask.NameToLayer("Area")) == null);

				Debug.Log("X" + x);
				Debug.Log("Y" + y);
	
				return new Vector3(x, y, 0);
		}
}
