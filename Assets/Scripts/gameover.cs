using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour {

	void Update () 
	{
		if(transform.position.y < -100)
		{
			SceneManager.LoadScene (2);
		}
	}
}