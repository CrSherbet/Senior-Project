using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller {

  private House house = new House();
  private Tree tree = new Tree();
  private RiceField rice = new RiceField();
  private Pond pond = new Pond();

  public static Options options = new Options();

  public static Model currModel;

  void Start () {
	
  }
	
  void Update () {
		
  }

  public void CalculateArea () {
	  currModel = new Model("9991", "Square", 4.0f, pond.getPond(), 
				        tree.getTree(), rice.getRice(), house.getHouse());
  }

}
