using UnityEngine;
using System.Collections;

public class SC_TH_CreateEnemy : MonoBehaviour {

	public float interval;
	public float count;
	public GameObject enemy;
	// Use this for initialization
	void Start () {
		interval = Random.Range (120.0f,240.0f);
		count = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		count++;
		if(count >= interval){
			GameObject spEnemy = enemy;
			GameObject spawn = Instantiate(spEnemy, new Vector3(gameObject.transform.position.x+Random.Range(-300.0f,300.0f),gameObject.transform.position.y,0),transform.rotation) as GameObject;
			//interval = Random.Range (120.0f,240.0f);
			count = 0.0f;
		}
	}
}
