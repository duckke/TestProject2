using UnityEngine;
using System.Collections;

public class BattleCharacterSwing : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag.Contains("Enemy")) {
			Destroy (coll.gameObject);
		}
	}
}
