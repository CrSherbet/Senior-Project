using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotate : MonoBehaviour {

		void OnMouseDrag(){
				float rotateX = Input.GetAxis("Mouse X") * 5 * Mathf.Deg2Rad;
				float rotateY = Input.GetAxis("Mouse Y") * 3 * Mathf.Deg2Rad;
				transform.RotateAround(Vector3.up, -rotateX);
				transform.RotateAround(Vector3.right, rotateY);
		}

}
