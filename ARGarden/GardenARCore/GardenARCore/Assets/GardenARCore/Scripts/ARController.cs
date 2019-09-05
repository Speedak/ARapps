using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;



public class ARController : MonoBehaviour{
    
    //We will fill this list with the planes that ARCore detected in the current frame
    private List<TrackedPlane> m_NewTrackedPlanes = new List<TrackedPlane>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        //ChekARCore session status
        if(Session.Status != SessionStatus.Tracking)
        {
            return;
        }
        
        //The following function will m_NewTrackedPlanes with the planes that ARCore detected in the current frame
        Session.GetTrackables<TrackedPlane>(m_NewTrackedPlanes, TrackableQueryFilter.New);
    }
}
