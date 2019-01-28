using UnityEngine;
using UnityEngine.UI;

public class InformationDetail : MonoBehaviour {

	private string TreeFormat = "";

	void Start () {
		string updateText = "Tree: " + Controller.currModel.tree[0].species + ", " + 
							Controller.currModel.tree[1].species + ", ";
		Text infoObj = GetComponent<Text>();
		infoObj.text = updateText;
	}
	
	// Update is called once per frame
	void Update () {

	}

}
