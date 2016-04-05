using UnityEngine;
using System.Collections;
using DG.Tweening;

public class BattleEnemyManager : MonoBehaviour {
	public	Transform	tr_enemyPanel;
	public	Transform[]	tr_spawnPoint;
	public	GameObject	pref_battleEnemy;

	// Use this for initialization
	void Start () {
		StartCoroutine("SpawnMonster");
	}
	
	// Update is called once per frame
	void Update () {

	}

	IEnumerator SpawnMonster() {

		while(this.gameObject.activeSelf == true) {

			GameObject obj = Instantiate(this.pref_battleEnemy) as GameObject;
			int side = Random.Range(0, 2);
			if (side == c.LEFT)
				obj.transform.localScale = new Vector3(1f, 1f, 1f);
			else if (side == c.RIGHT)
				obj.transform.localScale = new Vector3(-1f, 1f, 1f);

			obj.transform.SetParent(tr_enemyPanel);
			obj.transform.localPosition = tr_spawnPoint[side].localPosition;
			BattleEnemy be = obj.GetComponent<BattleEnemy>();
			int model = Random.Range(0, Global.MaxMonsterNum);
			be.setEnemy(side, model, g.gl.Monster[model].speed, g.gl.Monster[model].skill);
//			obj.transform.DOLocalMoveX(0f, 3f, false).SetEase(Ease.Linear);
			yield return new WaitForSeconds(0.5f);
		}
	}
}
