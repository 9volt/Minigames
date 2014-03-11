using UnityEngine;
using System.Collections;

public class Flip_Test : MonoBehaviour {
	public bool facingRight = false;			// For determining which way the test is currently facing.

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Jump") ){
			Debug.Log("Test Go!");
			Flip();			
		}
	}

	void Flip ()
	{
		// Switch the way the player is labelled as facing.
		facingRight = !facingRight;
		
		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
