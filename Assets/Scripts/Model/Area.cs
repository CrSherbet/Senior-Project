using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

class SortX : IComparer<Vector3> {
        public int Compare(Vector3 a, Vector3 b) {
            if (a.x == 0 || b.x == 0) { return 0; }
            return a.x.CompareTo(b.x);
        }
    }

    class SortY : IComparer<Vector3> {
        public int Compare(Vector3 a, Vector3 b) {
            if (a.y == 0 || b.y == 0) { return 0; }
            return a.y.CompareTo(b.y);
        }
    }
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
        List<Vector3> clockwisePos;
        if(areaPos[0].x == areaPos[1].x){
            if(areaPos[0].y > areaPos[1].y){
                clockwisePos = new List<Vector3>(areaPos);
            } else {
                clockwisePos = new List<Vector3>(areaPos);
                clockwisePos.Reverse();
            }
        } else if(areaPos[0].x < areaPos[1].x) {
            clockwisePos = new List<Vector3>(areaPos);
            clockwisePos.Reverse();
        } else {
            clockwisePos = new List<Vector3>(areaPos);
        }

        float xy = 0f;
        float yx = 0f;
        
        for(int i=0; i < clockwisePos.Count - 1; i++){
            xy += clockwisePos[i].x * clockwisePos[i+1].y;
            yx += clockwisePos[i].y * clockwisePos[i+1].x;
        }
        return Math.Abs((xy - yx)/2.0f);
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