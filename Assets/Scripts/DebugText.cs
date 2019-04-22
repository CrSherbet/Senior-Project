// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class DebugText : MonoBehaviour
// {

//     public Text mytext = null;
//     private string Point = "";

//     // Start is called before the first frame update
//     void Start()
//     {
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         Point = "kkkkkk : ";

//         if (PointCloudParticleExample.m_PointCloudData != null && PointCloudParticleExample.m_PointCloudData.Length > 0 && PointCloudParticleExample.maxPointsToShow > 0) 
//             {
//         foreach (Vector3 currentPoint in  PointCloudParticleExample.m_PointCloudData)
//                 {
//                     Point += currentPoint + "\n";
//                 }

//             }

//         mytext.text = Point;
//     }
// }
