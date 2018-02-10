using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainSceneUIManager : MonoBehaviour {
    Text resultTempText;



	// Use this for initialization
	void Start () {
        resultTempText = GameObject.Find("TempResult").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeScene(string name){
        switch(name){
            case "back":
                SceneManager.LoadScene("Title");
                break;
            case "forward":
                SceneManager.LoadScene("Result");
                break;
        }
    }

    public void Select(){
        resultTempText.text = "test";
    }

    //public void SelectElement(string name){
    //    switch (name) {
    //        case GameManagerSinglton.Element.Fire.ToString():
    //            GameManagerSinglton.currentSkill = GameManagerSinglton.Element.Fire;
    //            break;
    //        case "forward":
    //            SceneManager.LoadScene("Result");
    //            break;
    //    }
    //}
}
