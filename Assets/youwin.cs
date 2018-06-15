using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class youwin : MonoBehaviour {

	void Update () 
	{
		if(transform.position.z > 3600)
		{
			print (transform.position.z);
			SceneManager.LoadScene (3);
		}
	}
}