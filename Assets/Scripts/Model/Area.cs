using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Area {
    
    public string name { get; set;}
    public float size { get; set;}
	public Vector3 center { get; set; }
    public float scaleX { get; set; }
    public float scaleY { get; set; }
	public List<Vector3> areaPos { get; set; }

    public Area (){
        name = "Default Name";
        areaPos = new List<Vector3>();
        center = new Vector3(0,0,0);
        size = 0.0f;
        scaleX = 0.0f;
        scaleY = 0.0f;
    }

    public Area (string inputName, List<Vector3> inputAreaPos){
        name = inputName;
        areaPos = inputAreaPos;
        center = getCenter();
        size = getAreaSize();
        scaleX = findWidth();
        scaleY = findHeight();
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

    public float findWidth(){
        float width = Math.Abs(areaPos[0].x - center.x);
        for(int i=1; i<areaPos.Count-1; i++){
            if(Math.Abs(areaPos[i].x - center.x) < width){
                width = Math.Abs(areaPos[i].x - center.x);
            }
        }
        if(width - 50 > 0){
            return width - 50;
        }
        return width;
    }

    public float findHeight(){
        float height = Math.Abs(areaPos[0].y - center.y);
        for(int i=1; i<areaPos.Count-1; i++){
            if(Math.Abs(areaPos[i].y - center.y) < height){
                height = Math.Abs(areaPos[i].y - center.y);
            }
        }
        if(height - 50 > 0){
            return height - 50;
        }
        return height;
        
    }
}