﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InformationDetail : MonoBehaviour {

	void Start () {
		string updateText = "Tree: " + Controller.currModel.tree.species;
		Text infoObj = GetComponent<Text>();
		infoObj.text = updateText;
	}
	
	// Update is called once per frame
	void Update () {

	}

}