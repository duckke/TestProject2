using UnityEngine;
using System.Collections;

public class BattleCharacter : MonoBehaviour {

	
	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag.Contains("Enemy")) {
			Debug.Log ("Player Died");
		
//			g.bm.GameOver();
			Destroy(coll.gameObject);
		}
	}
}
