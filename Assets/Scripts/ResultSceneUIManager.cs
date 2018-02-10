using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultSceneUIManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void BackTitle(){
        SceneManager.LoadScene("Title");
    }

    public void BackMain(){
        SceneManager.LoadScene("main");
    }
}
