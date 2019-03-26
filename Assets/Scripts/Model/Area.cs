using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Area {
    
    public string name { get; set;}
    public float size { get; set;}
	public Vector3 center { get; set; }
	public List<Vector3> areaPos { get; set; }

    public Area (){
        name = "Default Name";
        areaPos = new List<Vector3>();
        center = new Vector3(0,0,0);
        size = 0.0f;
    }

    public Area (string inputName, List<Vector3> inputAreaPos){
        name = inputName;
        areaPos = inputAreaPos;
        center = getCenter();
        size = getAreaSize();
    }

    public float getAreaSize(){
        return 4.0f;
    }

    // find center of polygon
    public Vector3 getCenter() {
        float maxX = areaPos[0].x, maxY = areaPos[0].y;
        float minX = areaPos[0].x, minY = areaPos[0].y; 
        float centerX = 0.0f, centerY = 0.0f;

        for(int i = 0; i < areaPos.Count; i++) {
            if(areaPos[i].x > maxX) {
                maxX = areaPos[i].x;
            } 
            if(areaPos[i].x < minX) {
                minX = areaPos[i].x;
            } 
            if(areaPos[i].y > maxY) {
                maxY = areaPos[i].y;
            } 
            if(areaPos[i].y < minY) {
                minY = areaPos[i].y;
            } 
        }

        centerX = (maxX - minX) / 2 + minX;
        centerY = (maxY - minY) / 2 + minY;
        return new Vector3(centerX, centerY, 0.0f);
    }
}