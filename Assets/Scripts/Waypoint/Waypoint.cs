using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    public WaypointScriptable waypointData;
    public float speed = 5f;

    private Vector3 targetPoint;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = waypointData.pointA;
        targetPoint = waypointData.pointB;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPoint, speed * Time.deltaTime);

        if (transform.position == targetPoint)
        {
            targetPoint = targetPoint == waypointData.pointA ? waypointData.pointB : waypointData.pointA;
        }
    }
}
