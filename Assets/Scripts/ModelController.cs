using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelController : MonoBehaviour {

	void Start () {
		  LineRenderer lineRenderer = GetComponent<LineRenderer>();
			Vector3[] linePos = Controller.currModel.linePos;
			lineRenderer.positionCount = linePos.Length;
			for (int i = 0; i < linePos.Length; i++) {
          lineRenderer.SetPosition(i, linePos[i]);
      }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
