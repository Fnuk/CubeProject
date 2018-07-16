using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereDetection : MonoBehaviour {

    #region PUBLIC_MEMBER_VARIABLES

    public GameObject cube;

    #endregion // PUBLIC_MEMBER_VARIABLES


    #region PROTECTED_MEMBER_VARIABLES

    protected DefaultTrackableEventHandler cubeDetectionScript;

    #endregion // PROTECTED_MEMBER_VARIABLES

    #region UNITY_MONOBEHAVIOUR_METHODS

    private void Start()
    {
        cubeDetectionScript = cube.GetComponent<DefaultTrackableEventHandler>();
    }

    private void Update()
    {
        if (!cubeDetectionScript.IsTracked)
        {
            this.GetComponent<Rigidbody>().isKinematic = true;
        }
        else
        {
            this.GetComponent<Rigidbody>().isKinematic = false;
        }
            
    }

    #endregion // UNITY_MONOBEHAVIOUR_METHODS
}
