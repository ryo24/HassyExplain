using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerSinglton : MonoBehaviour {
    public enum Element{
        Fire,
        Water,
        Air,
        Ground
    }

    int MAX_SKILL_CAPACITY = 3;

    List<Element> currentSkills;

    //シングルトン処理
    static bool isCreated = false;
    private void Awake(){
        if (!isCreated) {
            DontDestroyOnLoad(this.gameObject);
            isCreated = true;
        }
        else {
            Destroy(this.gameObject);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
    public bool CanAddElemnt(Element buttonElement){

        //Max数との比較
        //二回目の選択だったら解除
        if (HasSkill(buttonElement) || currentSkills.Count  > MAX_SKILL_CAPACITY) {
            return false;
        }else{
            //選択可能なら、リストに追加してtrueを返却
            currentSkills.Add(buttonElement);
            return true;
        }

        
    }

    //そのエレメントが選択されているかを確認
    //利用イメージ：ゲーム中にスキル獲得などが行われた際に、選択画面と差が生まれるのでチェックする
    public bool isActived(Element buttonElement){
        if(HasSkill(buttonElement)){
            return false;
        }else{
            return true;
        }
    }

    //配列のなかにそのエレメントがあるかを確認
    //複数箇所で使うので関数として抜きだしている
    private bool HasSkill(Element checkElement){
        foreach( Element array in currentSkills){
            if(array == checkElement){
                return false;
            }
        }
        return true;
        
    }

}
