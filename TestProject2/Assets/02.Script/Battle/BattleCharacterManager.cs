using UnityEngine;
using System.Collections;
using DG.Tweening;

public class BattleCharacterManager : MonoBehaviour {
	
	public	Transform	tr_character;
	public	SpriteRenderer	sprite_character_swing;
	public	BoxCollider2D	coll_character_swing;
	
	private	float		swing_fade_time = 0.3f;

	// Use this for initialization
	void Start () {
		sprite_character_swing.color = new Color(1f, 1f, 1f, 0f);
		coll_character_swing.enabled = false;
	}


	public void ActiveSwing(int side) {
		switch (side) {
		case c.LEFT:			
			tr_character.localScale = new Vector3(-1f, 1f, 1f);
			sprite_character_swing.DOKill();
			StopCoroutine("ActiveOnSwingCollider");
			StartCoroutine("ActiveOnSwingCollider");
			break;
		case c.RIGHT:			
			tr_character.localScale = new Vector3(1f, 1f, 1f);
			sprite_character_swing.DOKill();
			StopCoroutine("ActiveOnSwingCollider");
			StartCoroutine("ActiveOnSwingCollider");
			break;
		}
	}

	IEnumerator ActiveOnSwingCollider() {
		coll_character_swing.enabled = true;
		sprite_character_swing.color = Color.white;
		while (coll_character_swing.enabled == true) {
			sprite_character_swing.DOFade(0f, swing_fade_time);
			yield return new WaitForSeconds(Time.smoothDeltaTime);
			coll_character_swing.enabled = false;
		}
	}
}
