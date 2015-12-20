using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SC_TH_time : MonoBehaviour {

	SC_TH_CharacterMove chCol;
	Transform jumper;
	Transform plat;
	Text score;
	bool end;
	private int count;
	// Use this for initialization
	void Start () {
		chCol = GameObject.FindGameObjectWithTag("Player").GetComponent <SC_TH_CharacterMove>();
		jumper = GameObject.FindGameObjectWithTag ("sp_player").transform;
		plat = GameObject.FindGameObjectWithTag("fl_floor").transform;
		score = GetComponent<Text>();
		count = 0;
		score.text = "0";
		end = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Debug.Log(end);

		if(!end){
			count++;
			score.text = "" + count; 
		}else{
			score.text = "Your final score:" + count;
			if(Input.GetKeyUp(KeyCode.Z) || Input.GetKeyUp(KeyCode.X) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow)){
				Application.LoadLevel (Application.loadedLevel);
			}
		}
		if(chCol.hit == true || jumper.position.y < plat.position.y){
			end = true;
		}
	}
}
