using UnityEngine;
using System.Collections;

public class SC_TH_TrigEn : MonoBehaviour {

	public GameObject spike;
	public GameObject player;
	private bool move;
	void Start(){
		move = false;
	}
	void FixedUpdate(){

	}

	void OnTriggerExit2D(Collider2D other){
		if(other.gameObject.tag == "sp_enemy"){
			GameObject spikePre = spike;
			GameObject tran = Instantiate (spikePre, new Vector3(this.gameObject.transform.position.x + 800,player.transform.position.y - 238, 0),transform.rotation) as GameObject;
			tran.transform.parent = player.transform;
			Destroy(other.gameObject);
			move = true;
		}
	}

}
