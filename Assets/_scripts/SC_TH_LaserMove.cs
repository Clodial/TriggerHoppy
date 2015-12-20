using UnityEngine;
using System.Collections;

public class SC_TH_LaserMove : MonoBehaviour {

	public float walkSp;
	public int die;
	private int counter;
	// Use this for initialization
	void Start () {
		walkSp = Time.deltaTime*500.0f;
		die = 50;
		counter = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		gameObject.transform.Translate(0,walkSp,0);
		counter++;
		if(counter >= die){
			Destroy (this.gameObject);
		}
	}
	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "sp_enemy"){
			Transform ot = other.gameObject.transform; //We're gonna make this game HARDER
			ot.position = new Vector3(ot.position.x,1000.0f,0.0f);
			Destroy (this.gameObject);
		}
	}
}
