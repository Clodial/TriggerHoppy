using UnityEngine;
using System.Collections;

public class SC_TH_EnemyRand : MonoBehaviour {

	public float walkSp;
	private int counter;
	private int change;
	// Use this for initialization
	void Start () {
		walkSp = Time.deltaTime*128.0f;
		counter = 0;
		change = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		counter++;
		if(counter >= 100){
			change = (int)Random.Range (0,3);
			counter = 0;
		}
		if(change == 0){
			gameObject.transform.Translate(0,-(walkSp)*1.5f,0);
		}else if(change == 1){
			gameObject.transform.Translate(0,walkSp/3,0);
		}else if(change == 2){
			gameObject.transform.Translate(walkSp/2,0,0);
		}else{
			gameObject.transform.Translate(-walkSp/2,0,0);
		}
		if(gameObject.transform.position.y < -600){
			Destroy (this.gameObject);
		}
	}
}
