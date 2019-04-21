using UnityEngine;
using System;
using System.Collections.Generic;

public class Model {
    public string Id { get; set;}
    public string name { get; set; }
    public Area area {get; set;}
    public Area pondArea { get; set; }
    public Area treeArea { get; set; }
    public Area riceArea { get; set; }
    public Area houseArea { get; set; }
    public List<Vector3> areaPos {get; set;}
    public List<Vector3> dividedAreaPos {get; set;}

    public Model (string inputID, List<Vector3> inputAreaPos) {
        Id = inputID;
        name = "ARShapeModel";
        areaPos = new List<Vector3>(inputAreaPos);
        area = new Area(inputID, inputAreaPos);
        dividedAreaPos = allocateArea();
    }

    public Model (string inputID, string inputName, List<Vector3> inputAreaPos) {
        Id = inputID;
        name = inputName;
        areaPos = new List<Vector3>(inputAreaPos);
        area = new Area(inputName, inputAreaPos);
        dividedAreaPos = allocateArea();
    }

    public List<Vector3> allocateArea(){
        float areaPercent = 0;
        int numOfPortion = 0;
        if(Controller.options.house) { areaPercent += 10; numOfPortion++; }
        if(Controller.options.pond) { areaPercent += 30; numOfPortion++; } 
        if(Controller.options.tree) { areaPercent += 30; numOfPortion++; }
        if(Controller.options.rice) { areaPercent += 30; numOfPortion++; } 
        int oldNumPortion = numOfPortion;
        List<Vector3> dividedPos = new List<Vector3>();

        float rationOfPortion = (100 - areaPercent)/areaPercent;
        float randPoint = UnityEngine.Random.Range(0, areaPos.Count-2);

        List<Vector3> remainPos = new List<Vector3>(areaPos);
        remainPos.RemoveAt(remainPos.Count-1);
        for(int i=0; i<randPoint; i++){
            remainPos.Add(remainPos[0]);
            remainPos.RemoveAt(0);
        }
        remainPos.Add(remainPos[0]);
        float portionAmount;

        if(Controller.options.pond && areaPos.Count == 4 && numOfPortion == oldNumPortion){
            portionAmount = area.getAreaSize() * ((rationOfPortion * 30) + 30)/100;
            List<Vector3> allocatedPos = CalculateTri(remainPos, portionAmount);
            pondArea = new Area("Pond", allocatedPos);
            numOfPortion--;
            dividedPos.AddRange(pondArea.areaPos);
            dividedPos.RemoveAt(dividedPos.Count-1);
        } else if(Controller.options.pond && numOfPortion > 1) { 
            portionAmount = area.getAreaSize() * ((rationOfPortion * 30) + 30)/100;
            List<Vector3> allocatedPos = CalculatePoint(remainPos, portionAmount);
            pondArea = new Area("Pond", allocatedPos);
            numOfPortion--;
            dividedPos.Insert(0, pondArea.areaPos[0]);
            dividedPos.AddRange(pondArea.areaPos);
            dividedPos.RemoveAt(dividedPos.Count-1);
        } else {
            pondArea = new Area("Pond", remainPos); 
            dividedPos.Insert(0, pondArea.areaPos[0]);
            dividedPos.AddRange(pondArea.areaPos); 
        }       

        if(Controller.options.tree && areaPos.Count == 4 && numOfPortion == oldNumPortion){
            portionAmount = area.getAreaSize() * ((rationOfPortion * 30) + 30)/100;
            List<Vector3> allocatedPos = CalculateTri(remainPos, portionAmount);
            treeArea = new Area("Tree", allocatedPos);
            numOfPortion--;
            dividedPos.AddRange(treeArea.areaPos);
            dividedPos.RemoveAt(dividedPos.Count-1);
        } else if(Controller.options.tree && numOfPortion > 1) {
            portionAmount = area.getAreaSize() * ((rationOfPortion * 30) + 30)/100;
            List<Vector3> allocatedPos = CalculatePoint(remainPos, portionAmount);
            treeArea = new Area("Tree", allocatedPos);
            numOfPortion--;
            dividedPos.Insert(0, treeArea.areaPos[0]);
            dividedPos.AddRange(treeArea.areaPos);
            dividedPos.RemoveAt(dividedPos.Count-1);
        } else {
            treeArea = new Area("Tree", remainPos); 
            dividedPos.Insert(0, treeArea.areaPos[0]);
            dividedPos.AddRange(treeArea.areaPos); 
        }

        if(Controller.options.house && areaPos.Count == 4 && numOfPortion == oldNumPortion){
            portionAmount = area.getAreaSize() * ((rationOfPortion * 30) + 30)/100;
            List<Vector3> allocatedPos = CalculateTri(remainPos, portionAmount);
            houseArea = new Area("House", allocatedPos);
            numOfPortion--;
            dividedPos.AddRange(houseArea.areaPos);
            dividedPos.RemoveAt(dividedPos.Count-1);
        } else if(Controller.options.house && numOfPortion > 1){
            portionAmount = area.getAreaSize() * ((rationOfPortion * 10) + 10)/100;
            List<Vector3> allocatedPos = CalculatePoint(remainPos, portionAmount);
            houseArea = new Area("House", allocatedPos);
            numOfPortion--;
            dividedPos.Insert(0, houseArea.areaPos[0]);
            dividedPos.AddRange(houseArea.areaPos);
            dividedPos.RemoveAt(dividedPos.Count-1);
        } else {
            houseArea = new Area("house", remainPos); 
            dividedPos.Insert(0, houseArea.areaPos[0]);
            dividedPos.AddRange(houseArea.areaPos); 
        }

        if(Controller.options.rice) {
            riceArea = new Area("Rice", remainPos); 
            dividedPos.Insert(0, riceArea.areaPos[0]);
            dividedPos.AddRange(riceArea.areaPos);   
            dividedPos.RemoveAt(dividedPos.Count-1);         
        } 
        return dividedPos;
    }

    public List<Vector3> CalculateTri(List<Vector3> remainPos, float portionAmount){
        Vector3 posA = findPointInLine(new Vector3[]{remainPos[0], remainPos[1]});
        Vector3 posB = findPointInLine(new Vector3[]{remainPos[0], remainPos[2]});    
        List<Vector3> testPoints = new List<Vector3>(){remainPos[0], posA, posB, remainPos[0]};
        Area tri = new Area("tri", testPoints);
        float T = portionAmount/tri.getAreaSize();
        posB.x = (1 - T) * testPoints[0].x + T * testPoints[2].x;
        posB.y = (1 - T) * testPoints[0].y + T * testPoints[2].y;
        testPoints[2] = new Vector3(posB.x, posB.y);
        remainPos.RemoveAt(0);
        remainPos.RemoveAt(remainPos.Count-1);
        remainPos.Reverse();
        remainPos.Insert(0, posB);
        remainPos.Add(posA);
        remainPos.Add(posB);
        return testPoints;
    }

    public List<Vector3> CalculatePoint(List<Vector3> remainPos, float portionAmount){
        Vector3 posA = findPointInLine(new Vector3[]{remainPos[1], remainPos[2]});            
        List<Vector3> newAreaPos = new List<Vector3>(){remainPos[0], remainPos[1], posA}; 
        Vector3 posB = findPointByArea(portionAmount, newAreaPos, remainPos[remainPos.Count -2]);
        remainPos.RemoveRange(0, 2);
        remainPos.RemoveAt(remainPos.Count-1);
        remainPos.Reverse();
        remainPos.Insert(0, posB);
        remainPos.Add(posA);
        remainPos.Add(posB);
        newAreaPos.Add(posB);
        newAreaPos.Add(remainPos[0]);
        return newAreaPos;
    }

    public Vector3 findPointInLine(Vector3[] points){
        // calculate distance between the two points
        float DT = (float) Math.Sqrt(Math.Pow((points[1].x - points[0].x), 2) + Math.Pow((points[1].y - points[0].y), 2));
        float D = UnityEngine.Random.Range(DT/3, DT/2);
       
        float x, y;
        float T = D / DT;

        x = (1 - T) * points[0].x + T * points[1].x;
        y = (1 - T) * points[0].y + T * points[1].y;
        return new Vector3(x, y);
    }

    public Vector3 findPointByArea(float portion, List<Vector3> points, Vector3 lastPoint){
        Area temp;
        float DT = (float) Math.Sqrt(Math.Pow((lastPoint.x - points[0].x), 2) + Math.Pow((lastPoint.y - points[0].y), 2));
        float D = UnityEngine.Random.Range(0, DT);

        float x, y, ratio;
        float T = D / DT;

        x = (1 - T) * points[0].x + T * lastPoint.x;
        y = (1 - T) * points[0].y + T * lastPoint.y;
        List<Vector3> testPoints = new List<Vector3>(points);
        testPoints.Add(new Vector3(x, y));
        testPoints.Add(points[0]);
        temp = new Area("test", testPoints);
        if(!(temp.getAreaSize()/portion > 0.95 && temp.getAreaSize()/portion <=1)){
            ratio = portion/temp.getAreaSize();
            T = T*ratio;
            x = (1 - T) * points[0].x + T * lastPoint.x;
            y = (1 - T) * points[0].y + T * lastPoint.y;
        }
        return new Vector3(x, y);      
    }
}


