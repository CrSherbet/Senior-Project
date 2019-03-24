using UnityEngine;
using UnityEngine.UI;

public class InformationDetail : MonoBehaviour {

		string HouseFormat = string.Format("<b>House</b>: {0}, {1}, {2}\n", 
			Controller.currModel.house.type,	Controller.currModel.house.roof, Controller.currModel.house.material);
		string TreeFormat = string.Format("<b>Tree</b>: {0}, {1}\n", 
			Controller.currModel.tree[0].species, Controller.currModel.tree[1].species);
		string RiceFieldFormat = string.Format("<b>Rice</b>: {0}, {1}\n", 
			Controller.currModel.rice[0].species, Controller.currModel.rice[1].species);
		string PondFormat = string.Format("<b>Pond</b>: {0}, {1}\n", 
			Controller.currModel.pond[0].species, Controller.currModel.pond[1].species);


		void Start () {
				Text infoObj = GetComponent<Text>();
				infoObj.text = HouseFormat + TreeFormat + RiceFieldFormat + PondFormat ;
		}
		
		// Update is called once per frame
		void Update () {

		}

}
