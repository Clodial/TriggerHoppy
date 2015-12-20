using UnityEngine;
using System.Collections;

public class SC_TH_2ndCharMove : MonoBehaviour {

	public bool grounded;
	private Animator anim;
	// Use this for initialization
	void Start () {
		grounded = false;
		anim = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(grounded){
			anim.SetBool ("air",false);
			if(Input.GetKey(KeyCode.UpArrow)){
				GetComponent<Rigidbody2D>().AddForce(new Vector2(0,10800.0f));
				grounded = false;

			}
		}else{
			anim.SetBool ("air",true);
		}
	}
	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.tag == "fl_floor"){
			grounded = true;
		}
	}
	void OnCollisionExit2D(Collision2D other){
		if(other.gameObject.tag == "fl_floor"){
			grounded = false;
		}
	}

}
