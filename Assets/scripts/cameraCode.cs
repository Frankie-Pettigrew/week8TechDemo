using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraCode : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
		Vector3 averagePos = new Vector3 ();

		foreach (Transform list in manager.tileList) {
			averagePos += list.transform.position;

			averagePos /= manager.tileList.Count;

			this.transform.position = new Vector3 (averagePos.x, this.transform.position.y, averagePos.z);
		}
	}
}
