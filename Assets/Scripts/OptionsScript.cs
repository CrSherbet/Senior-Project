using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsScript : MonoBehaviour {

	void Start () {
    
    }

	void Update () {
		
	}

    public void SetOptionValuse () {
        GameObject.Find("RegionDropdown").GetComponent<Dropdown>().value = Controller.options.region;
        GameObject.Find("HouseToggle").GetComponent<Toggle>().isOn = Controller.options.house;
        GameObject.Find("PondToggle").GetComponent<Toggle>().isOn = Controller.options.pond;
        GameObject.Find("RiceToggle").GetComponent<Toggle>().isOn = Controller.options.rice;
        GameObject.Find("TreeToggle").GetComponent<Toggle>().isOn = Controller.options.tree;
    }

    public void CompositionChange (Toggle option) {
        if (option.name == "HouseToggle") {
            Controller.options.house = option.isOn;
        } else if (option.name == "PondToggle") {
            Controller.options.pond = option.isOn;
        } else if (option.name == "RiceToggle") {
            Controller.options.rice = option.isOn;
        } else if (option.name == "TreeToggle") {
            Controller.options.tree = option.isOn;
        } 
    }

    public void RegionChange (Dropdown selectedRegion){
        Controller.options.region = selectedRegion.value;
        Controller.options.regionName = selectedRegion.captionText.text;
    }
  
}
