using UnityEngine;

[CreateAssetMenu(fileName = "WaypointData", menuName = "ScriptableObjects/WaypointScriptable", order = 1)]
public class WaypointScriptable : ScriptableObject
{
    public Vector3 pointA;
    public Vector3 pointB;
}
