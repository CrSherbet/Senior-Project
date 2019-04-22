using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.iOS;
using UnityEngine.UI;
using System;
using System.IO;

public class PointCloudParticleExample : MonoBehaviour
{
    public ParticleSystem pointCloudParticlePrefab;
    public int maxPointsToShow;
    // public static bool PointUpdated {get; set;}
    public static bool PointUpdated = false;
    public float particleSize = 1.0f;
    Vector3[] m_PointCloudData;
    public static List<Vector3> parts = new List<Vector3>();
    bool frameUpdated = false;
    ParticleSystem currentPS;
    ParticleSystem.Particle [] particles;
    public Text mytext = null;
    private string Point = "";

    // Use this for initialization
    void Start ()
    {
        PointUpdated = false;
        UnityARSessionNativeInterface.ARFrameUpdatedEvent += ARFrameUpdated;
        currentPS = Instantiate (pointCloudParticlePrefab);
        m_PointCloudData = null;
        frameUpdated = false;
        Point = "point : \n";

    }

    public void ARFrameUpdated(UnityARCamera camera)
    {
        if (camera.pointCloud != null)
        {
           m_PointCloudData = camera.pointCloud.Points;
        }
        // frameUpdated = true;
    }

    // Update is called once per frame
    void Update ()
    {
        // if (frameUpdated)
        // {
            if (m_PointCloudData != null && m_PointCloudData.Length > 0 && maxPointsToShow > 0)
            {
                int numParticles = Mathf.Min (m_PointCloudData.Length, maxPointsToShow);
                ParticleSystem.Particle[] particles = new ParticleSystem.Particle[numParticles];
                Vector3[] drawingPoint = new Vector3[numParticles];
                int index = 0;
                foreach (Vector3 currentPoint in m_PointCloudData)
                {
                    drawingPoint [index] = new Vector3 (currentPoint.x ,currentPoint.y, currentPoint.z);
                    particles [index].position = currentPoint;
                    particles [index].startColor = new Color (1.0f, 1.0f, 1.0f);
                    particles [index].startSize = particleSize;
                    index++;
                    if (index >= numParticles) break;
                }
                currentPS.SetParticles (particles, numParticles);
                int idx = 0;
                if(PointUpdated){
                    Point += numParticles+ "______num____\n";
                    Point += drawingPoint.Length+ "___draw_____\n";
                    int num = numParticles ;
                    Vector3[] keep = new Vector3[numParticles];
                    foreach (Vector3 cur in drawingPoint)
                            {
                                if(idx < numParticles ){
                                    keep[idx] = new Vector3 (cur.x ,cur.y, cur.z);
                                    idx++;
                                }
                            }
                    int j = 0;
                    int cc = 0;
                    foreach (Vector3 curr in keep)
                            {
                                bool isDiffPoint = false;
                                if(j == 0)
                                {
                                    parts.Add(curr);
                                }else{
                                    for(int w=0 ; w < parts.Count ; w++)
                                        {
                                            if(Math.Abs(curr.x-parts[w].x) > 0.02 || Math.Abs(curr.z-parts[w].z) > 0.02){
                                               isDiffPoint = true;
                                               cc++ ;
                                            } else {
                                                isDiffPoint = false;
                                                break;
                                            }
                                        }
                                        if(isDiffPoint){
                                            parts.Add(curr);
                                        }
                                }
                                j++;
                            }
                            Point += cc+ "____loop____";
                            Point += parts.Count + ":___Parts_____\n";
                foreach (Vector3 i in parts){
                     Point += i.ToString("F4") + "\n";
                }
                    PointUpdated = false;
                }
            }
            else
            {
                ParticleSystem.Particle[] particles = new ParticleSystem.Particle[1];
                particles [0].startSize = 0.0f;
                currentPS.SetParticles (particles, 1);
            }
            frameUpdated = false;
            mytext.text = Point;
        // }
    }
}

