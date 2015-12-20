using UnityEngine;
using System.Collections;

public class SC_TH_EnemyMove : MonoBehaviour {

	public float walkSp;
	
	// Use this for initialization
	void Start () {
		walkSp = Time.deltaTime*128.0f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		gameObject.transform.Translate(0,-walkSp,0);
		if(gameObject.transform.position.y < -600){
			Destroy (this.gameObject);
		}
	}

}
