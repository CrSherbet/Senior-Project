using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelController : MonoBehaviour {

	void Start () {
		  LineRenderer lineRenderer = GetComponent<LineRenderer>();
			Vector3[] linePos = Controller.currModel.linePos;
			
			Vector3[] area = Controller.currModel.area;
			
			var result = new List<Vector3>();
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
		
	}
}
