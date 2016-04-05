using UnityEngine;
using System.Collections;
using DG.Tweening;

public class BattleEnemy : MonoBehaviour {
	public	SpriteRenderer image_model;

	public	int		side;
	public	int		model;
	public	float	speed;
	public	int		skill;


	public void setEnemy(int side, int model, float speed, int skill) {
		this.side = side;
		this.model = model;
		this.speed = speed + Random.value;
		this.skill = skill;

		this.setEnemyModel();
		StartCoroutine("EnemyMove");
	}
	private void setEnemyModel() {
		image_model.sprite = Resources.Load<Sprite>(string.Format("Sprite/Monster/monster_{0}", model));

	}

	IEnumerator EnemyMove() {
		while (this.gameObject.activeSelf == true) {
			if (side == c.LEFT) {
				this.transform.Translate(Vector3.right * speed * Time.smoothDeltaTime);
				if (this.transform.localPosition.x >= 0)
					Destroy(this.gameObject);
			}
			else if (side == c.RIGHT) {
				this.transform.Translate(Vector3.left * speed * Time.smoothDeltaTime);
				if (this.transform.localPosition.x <= 0)
					Destroy(this.gameObject);

			}
			yield return new WaitForSeconds(Time.smoothDeltaTime);
		}
	}
}
