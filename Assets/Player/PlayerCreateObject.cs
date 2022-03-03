using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCreateObject : MonoBehaviour
{
    public bool SHOW_DEBUG_LOG = false;
    public int CubeCount = 1;
    public Transform player;
    public Vector3 cubeOffset;

    GameObject obj;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (SHOW_DEBUG_LOG)
            {
                Debug.Log("Spawning cube...");
            }
            // spawn object
            obj = new GameObject("Cube " + CubeCount);
            // add the THINGs
            obj.AddComponent<Rigidbody>();
            obj.AddComponent<BoxCollider>();
            obj.AddComponent<MeshRenderer>();

            // add mesh to created component
            MeshFilter mesh = obj.AddComponent<MeshFilter>();
            GameObject tempGo = GameObject.CreatePrimitive(PrimitiveType.Cube);
            mesh.mesh = tempGo.GetComponent<MeshFilter>().mesh;
            Destroy(tempGo);
    
            // make object render :him:
            obj.GetComponent<MeshRenderer>().material.color = Color.red;
            obj.GetComponent<Renderer>().enabled = true;

            // move object to player position and stop
            obj.transform.position = player.position + cubeOffset;

            if (obj)
            {
                if (SHOW_DEBUG_LOG)
                {
                    Debug.Log("Cube spawned");
                }
                CubeCount += 1;
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            if (SHOW_DEBUG_LOG)
            {
                Debug.Log("Spawning sphere...");
            }
            // spawn object
            obj = new GameObject("Sphere " + CubeCount);
            // add the THINGs
            obj.AddComponent<Rigidbody>();
            obj.AddComponent<BoxCollider>();
            obj.AddComponent<MeshRenderer>();

            // add mesh to created component
            MeshFilter mesh = obj.AddComponent<MeshFilter>();
            GameObject tempGo = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            mesh.mesh = tempGo.GetComponent<MeshFilter>().mesh;
            Destroy(tempGo);
    
            // make object render :him:
            obj.GetComponent<MeshRenderer>().material.color = Color.blue;
            obj.GetComponent<Renderer>().enabled = true;

            // move object to player position and stop
            obj.transform.position = player.position + cubeOffset;

            if (obj)
            {
                if (SHOW_DEBUG_LOG)
                {
                    Debug.Log("Sphere spawned");
                }
                CubeCount += 1;
            }
        }
    }
}
