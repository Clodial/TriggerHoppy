using UnityEngine;
using System.Collections;

public class SC_TH_EnemyZig : MonoBehaviour {

	public float walkSp;
	private int counter;
	private bool change;
	// Use this for initialization
	void Start () {
		walkSp = Time.deltaTime*128.0f;
		counter = 0;
		change = true;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		counter++;
		if(counter >= 200){
			if(change == true){
				change = false;
			}else{
				change = true;
			}
			counter = 0;
		}
		if(change){
			gameObject.transform.Translate((walkSp/2),-walkSp,0);
		}else{
			gameObject.transform.Translate(-(walkSp/2),-walkSp,0);
		}
		if(gameObject.transform.position.y < -600){
			Destroy (this.gameObject);
		}
	}
}
