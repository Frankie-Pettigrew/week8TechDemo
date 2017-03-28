using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class manager : MonoBehaviour {
	public Transform pathmaker;
	public Text text;
	public static int maxSize = 0;
	public static List<Transform> pathmakerList = new List<Transform> ();
	public static List<Transform> tileList = new List<Transform>();
	// Use this for initialization
	void Start () {
		maxSize = 0;
		Instantiate (pathmaker, Vector3.zero, Quaternion.identity);
		pathmakerList.Clear ();
		tileList.Clear ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
		text.text = "map size: " + maxSize + " press R to restart";
	}
}
