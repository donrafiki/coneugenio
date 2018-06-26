using UnityEngine;

public class playercollision : MonoBehaviour {

	void OnCollisionEnter (Collision collisionInfo) 
	{
		if (collisionInfo.collider.tag == "obstacle")
		{
			Debug.Log ("We hit an obstacle!");
		}
	}

}
