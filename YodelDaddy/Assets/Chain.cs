using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chain : MonoBehaviour {
    public Transform target;

    public static bool isFired;
	void Start () {
        isFired = false;
	}
	
	void Update () {
        if (isFired)
        {

        }
        else
        {
            transform.position = target.position;
        }
	}
}
