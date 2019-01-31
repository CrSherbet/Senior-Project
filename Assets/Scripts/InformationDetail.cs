using UnityEngine;
using UnityEngine.UI;

public class InformationDetail : MonoBehaviour {

	string TreeFormat = string.Format("Tree: {0}, {1}", 
		Controller.currModel.tree[0].species, Controller.currModel.tree[1].species);

	void Start () {
		Text infoObj = GetComponent<Text>();
		infoObj.text = TreeFormat;
	}
	
	// Update is called once per frame
	void Update () {

	}

}
