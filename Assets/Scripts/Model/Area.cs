using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Area {
    public Vector3[] areaPoint { get; set; }
    public Vector3 centerPoint { get; set; }

    public Area() {

    }

    public Area (Vector3[] inputPoint, Vector3 inputcenterPoint) {
        areaPoint = inputPoint;
        centerPoint = inputcenterPoint;
    }

    // find center of polygon
    public Vector3 getValue(Vector3[] areaArray) {
        float maxX = areaArray[0].x, maxY = areaArray[0].y;
        float minX = areaArray[0].x, minY = areaArray[0].y; 
        float centerX = 0.0f, centerY = 0.0f;

        for(int i = 0; i < areaArray.Length; i++) {
            if(areaArray[i].x > maxX) {
                maxX = areaArray[i].x;
            } 
            if(areaArray[i].x < minX) {
                minX = areaArray[i].x;
            } 
            if(areaArray[i].y > maxY) {
                maxY = areaArray[i].y;
            } 
            if(areaArray[i].y < minY) {
                minY = areaArray[i].y;
            } 
        }

        centerX = (maxX - minX) / 2 + minX;
        centerY = (maxY - minY) / 2 + minY;
        return new Vector3(centerX, centerY, 0.0f);
    }

}