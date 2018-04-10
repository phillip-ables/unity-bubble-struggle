using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chain : MonoBehaviour {
    public Transform player;

    public static bool isFired;
	void Start () {
        isFired = false;
	}
	
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            isFired = true;
            Debug.Log("Fire!");
        }
        if (isFired)
        {
            //we want to effect its scale and such

        }
        else
        {
            transform.position = player.position;
        }
	}
}
