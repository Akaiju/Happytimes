using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChangeObject : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        void OnCollisionEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
                SceneManager.LoadScene("SecondScene");
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
