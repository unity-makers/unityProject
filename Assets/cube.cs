using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter(Collision col)
	{
		Debug.Log ("hit sth");
	}

}
