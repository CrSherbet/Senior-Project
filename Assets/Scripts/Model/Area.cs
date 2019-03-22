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
    public Vector3 getValue(Vector3[] test) {
        float maxX = test[0].x, maxY = test[0].x;
        float minX = test[0].y, minY = test[0].y; 
        float centerX = 0.0f, centerY = 0.0f;

        for(int i = 0; i < test.Length; i++) {
            if(test[i].x > maxX) {
                maxX = test[i].x;
            } 
            if(test[i].x < minX) {
                minX = test[i].x;
            } 
            if(test[i].y > maxY) {
                maxY = test[i].y;
            } 
            if(test[i].y < minY) {
                minY = test[i].y;
            } 
        }

        centerX = (maxX - minX) / 2 + minX;
        centerY = (maxY - minY) / 2 + minY;
        return new Vector3(centerX, centerY, 0.0f);
    }

}