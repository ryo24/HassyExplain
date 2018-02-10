using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//このクラスはこのスクリプトがついているオブジェクトのことだけを管理する。
//残りは管理役
public class SkillButton : MonoBehaviour {
    public GameManagerSinglton.Element element;
    GameManagerSinglton manager;

	// Use this for initialization
	void Start () {
        manager = GameObject.Find("GameManagerSinglton").GetComponent<GameManagerSinglton>();

        if(manager.isActived(element)){
            this.gameObject.GetComponent<Text>().text = element + "\n Selected";
        }else{
            this.gameObject.GetComponent<Text>().text = element.ToString();
        }
	}
	

    public void Pressed(){
        if(manager.CanAddElemnt(element)){
            
        }else{
            
        }
        
    }
}
