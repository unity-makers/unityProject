using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere : MonoBehaviour {

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "Floor") {
			Debug.Log ("hit floor");
		}
	}
}
