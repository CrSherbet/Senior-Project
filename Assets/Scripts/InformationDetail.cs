using UnityEngine;
using UnityEngine.UI;

public class InformationDetail : MonoBehaviour {

	 	private Pond[] pond;
    private Tree[] tree;
    private RiceField[] rice;
    private House house;
		private string HouseFormat = "";
		private string RiceFieldFormat = "";
		private string PondFormat = "";
		private string TreeFormat = "";

		void Start () {
			  pond = new Pond().getDetail();
        tree = new Tree().getDetail();
        rice = new RiceField().getDetail();
        house = new House().getDetail();
			
				if(house != null) {
						HouseFormat = string.Format("<b>House</b>: {0}, {1}, {2}\n", house.type,	house.roof, house.material);
				}	
				
				if(tree != null) {
						TreeFormat = string.Format("<b>Tree</b>: {0}, {1}\n", tree[0].species, tree[1].species);
				}
				
				if(rice != null) {
						RiceFieldFormat = string.Format("<b>Rice</b>: {0}, {1}\n", rice[0].species, rice[1].species);
				}
				
				if(pond != null) {
						PondFormat = string.Format("<b>Pond</b>: {0}, {1}\n", pond[0].species, pond[1].species);
				}
					
				Text infoObj = GetComponent<Text>();
				infoObj.text = HouseFormat + TreeFormat + RiceFieldFormat + PondFormat ;
		}
		
		// Update is called once per frame
		void Update () {

		}

}
