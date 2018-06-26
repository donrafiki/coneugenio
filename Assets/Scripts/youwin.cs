using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class youwin : MonoBehaviour {

	void Update () 
	{
		if(transform.position.z > 3790 && transform.position.y >= 0)
		{
			print (transform.position.z);
			SceneManager.LoadScene (3);
		}
	}
}