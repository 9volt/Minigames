using UnityEngine;
using System.Collections;

public class block_fall : MonoBehaviour {
	int i;
	bool fallen;
	public Transform player;
	Vector3 myhome;
	
	// Use this for initialization
	void Start () {
		i = 0;
		fallen = false;
		myhome = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		if( (Mathf.Abs(player.position.x - transform.position.x ) < .5) && (!fallen) && ((Mathf.Abs(player.position.y - transform.position.y ) < 2.8))){
			gameObject.AddComponent("Rigidbody2D");
			fallen = true;
		}

	}
}
