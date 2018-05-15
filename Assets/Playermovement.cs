using UnityEngine;

public class Playermovement : MonoBehaviour {

	public Rigidbody rb;

	public float forwardForce = 2000f;

	// Use this for initialization
	void FixedUpdate () 
	{
		// add a forward force
		rb.AddForce (0, 0, forwardForce * Time.deltaTime);

		if (Input.GetKey("d"))
		{
			rb.AddForce (500 * Time.deltaTime, 0, 0);
		}

		if (Input.GetKey("a"))
		{
			rb.AddForce (-500 * Time.deltaTime, 0, 0);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
