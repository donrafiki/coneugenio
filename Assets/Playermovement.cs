using UnityEngine;

public class Playermovement : MonoBehaviour {

	public Rigidbody rb;

	public float forwardForce = 2000f;

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
}