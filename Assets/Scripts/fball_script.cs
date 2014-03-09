using UnityEngine;
using System.Collections;

public class fball_script : MonoBehaviour {
	int i;
	bool up;

	// Use this for initialization
	void Start () {
		i = 0;
		up = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (i > 50){
			up = !up;
			i = 0;
		}
		if (up){
			Vector3 newy = transform.position;
			newy.y -= .05f;
			transform.position = newy;
		}else{
			Vector3 newy = transform.position;
			newy.y += .05f;
			transform.position = newy;
		}
		i++;


	}
}
