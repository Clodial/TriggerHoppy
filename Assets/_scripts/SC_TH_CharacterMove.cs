using UnityEngine;
using System.Collections;

public class SC_TH_CharacterMove : MonoBehaviour {

	public GameObject pShot;
	private Transform selfie;
	private float walkSp;
	private int interval;
	private int state;
	public bool hit;
	// Use this for initialization
	void Start () {
		selfie = this.transform;
		walkSp = Time.deltaTime*96.0f;
		interval = 0;
		state = 0;
		hit = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		interval++;
		//left right controls
		if(Input.GetKey(KeyCode.LeftArrow)){
			if((state == 0 && selfie.position.x > -300) || (state == 1 && selfie.position.x > -2300) || (state == 2 && selfie.position.x > 1700)){
				selfie.Translate(-walkSp,0,0);
			}
		}else if(Input.GetKey(KeyCode.RightArrow)){
			if((state == 0 && selfie.position.x < 300) || (state == 1 && selfie.position.x < -1700) || (state == 2 && selfie.position.x < 2300)){
				selfie.Translate(walkSp,0,0);
			}
		}

		//up down controls
		if(Input.GetKey(KeyCode.UpArrow)){
			if(selfie.position.y < 400)
			selfie.Translate(0,walkSp,0);
		}else if(Input.GetKey(KeyCode.DownArrow)){
			if(selfie.position.y > -400)
			selfie.Translate(0,-walkSp,0);
		}

		if(Input.GetKey (KeyCode.Z)){
			if(interval >= 10){
				GameObject weap = pShot;
				GameObject fire = Instantiate (weap,new Vector3(selfie.position.x,selfie.position.y+5, 1), transform.rotation) as GameObject;
				interval = 0;
			}
		}
		if(Input.GetKeyUp (KeyCode.X)){
			Transform temp = selfie;
			if(selfie.position.x >= -300 && selfie.position.x <= 300){
				temp.position = new Vector3(-2000.0f,selfie.position.y, selfie.position.z);
				state = 1;
			}else if(selfie.position.x >= -2300 && selfie.position.x <= -1700){
				temp.position = new Vector3(2000.0f,selfie.position.y, selfie.position.z);
				state = 2;
			}else{
				temp.position = new Vector3(0.0f,selfie.position.y, selfie.position.z); 
				state = 0;
			}
		}
	}
	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "sp_enemy"){
			Debug.Log("yo");
			hit = true;
		}
	}
}
