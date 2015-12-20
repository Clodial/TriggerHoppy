using UnityEngine;
using System.Collections;

public class SC_TH_LandMove : MonoBehaviour {

	public float walkSp;
	
	// Use this for initialization
	void Start () {
		walkSp = Time.deltaTime*32.0f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		gameObject.transform.Translate(0,-walkSp,0);
		if(gameObject.transform.position.y < -2000){
			gameObject.transform.position = new Vector3(this.transform.position.x,1000.0f, this.transform.position.z);
		}
	}
}
