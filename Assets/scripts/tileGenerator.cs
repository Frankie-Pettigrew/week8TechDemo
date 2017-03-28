using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class tileGenerator : MonoBehaviour {

	int counter = 0;
	public float pathSize;
	float maxRand;
	public Transform tileFab;
	public Transform logFab;
	public Transform rockFab;
	public Transform shroomFab;
	public Transform pathmakerSphere;

	void Start() {
		pathSize = Random.Range (30f, 150f);
		maxRand = Random.Range(3f, 6f);
	}
	
	// Update is called once per frame
	void Update () {
		if (manager.maxSize <= 500) {
			if (counter < pathSize) {
				float rando = Random.Range (0f, 1f);
				if (rando < 0.25f) {
					transform.Rotate (0f, 90f, 0f);
				} else if (rando < .5f && rando >= .25f) {
					transform.Rotate (0f, -90f, 0f);
				} else if (rando >= .5f) {
					if (manager.pathmakerList.Count < 2) {
						Transform pathClone = Instantiate (pathmakerSphere, transform.position, Quaternion.identity);
						manager.pathmakerList.Add (pathClone);
					} else if (manager.pathmakerList.Count > 2 && rando >= .95f) {
						Transform pathClone = Instantiate (pathmakerSphere, transform.position, Quaternion.identity);
						manager.pathmakerList.Add (pathClone);
					}
				}
				float randy = Random.Range (0f, maxRand);
				Transform newTile;
				if (randy < 2) {
					newTile = Instantiate (tileFab, transform.position, Quaternion.identity);
				} else if (randy < 2.5f && randy >= 2) {
					newTile = Instantiate (logFab, transform.position, Quaternion.identity);
				} else if (randy < 3 && randy >= 2.5f) {
					newTile = Instantiate (rockFab, transform.position, Quaternion.identity);
				} else if (randy < 3.5f && randy >= 3) {
					newTile = Instantiate (shroomFab, transform.position, Quaternion.identity);
				} else {
					newTile = Instantiate (tileFab, transform.position, Quaternion.identity);
				}
				counter++;
				manager.maxSize++;
				transform.Translate (Vector3.forward * 5);
				manager.tileList.Add (newTile);
			} else {
				manager.pathmakerList.Remove (gameObject.transform);
				Destroy (gameObject);
			}
		}
	}
}
