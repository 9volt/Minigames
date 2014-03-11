using UnityEngine;
using System.Collections;

public class chasing_fball : MonoBehaviour {
	bool see_cat = false;
	public Transform player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ((!see_cat) && ((Mathf.Abs(player.position.y - transform.position.y ) < .5))){
			see_cat = true;
		}

		if (see_cat && transform.position.x > 5){
			Vector3 newx = transform.position;
			newx.x -= .08f;
			transform.position = newx;
		}

	}
}
