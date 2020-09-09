using GoogleARCore;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARController : MonoBehaviour
{
    private List<TrackedPlane> trackedPlanes = new List<TrackedPlane>();

    public GameObject GridPrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Session.Status != SessionStatus.Tracking)
        {
            return;
        }

        Session.GetTrackables<TrackedPlane>(trackedPlanes, TrackableQueryFilter.New);

        for(int i = 0; i<trackedPlanes.Count; i++)
        {
            GameObject grid = Instantiate(GridPrefab, Vector3.zero, Quaternion.identity, transform);

            grid.GetComponent<GridVisualiser>().Initialize(trackedPlanes[i]);
        }
    }
}
