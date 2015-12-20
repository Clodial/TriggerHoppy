using UnityEngine;
using System.Collections;

public class SC_TH_SpikeMove : MonoBehaviour {

	public float walkSp;
	// Use this for initialization
	void Start () {
		walkSp = Time.deltaTime*100;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		gameObject.transform.Translate(-walkSp,0,0);
		if(gameObject.transform.position.x < gameObject.transform.parent.transform.position.x-800){
			gameObject.transform.position = new Vector3(gameObject.transform.parent.transform.position.x + 800,this.transform.position.y,this.transform.position.z);
		}
	}
}
