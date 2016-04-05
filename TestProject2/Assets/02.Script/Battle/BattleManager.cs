using UnityEngine;
using System.Collections;
using DG.Tweening;

public class BattleManager : MonoBehaviour {

	public	BattleCharacterManager	bcm = null;
	public	BattleEnemyManager		bem = null;
	public	BattleTouchManager		btm = null;


	private	int		_score = 0;
	private int		_best_score = 0;

	public	bool	is_playing = false;

	void Awake () {
		g.bm = this;
	}


	// Use this for initialization
	void Start () {

	}

	public void GameStart() {


	}

	public void GameOver() {


	}
}
