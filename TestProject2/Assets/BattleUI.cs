using UnityEngine;
using System.Collections;

public class BattleUI : MonoBehaviour {


	public	BackgroundVC	backgroundVC;
	public	GameMainVC		gameMainVC;
	public	BattleHUD		battleHUD;

	void Awake() {
		g.bui = this;
	}
	// Use this for initialization
	void Start() {
		backgroundVC.initView();
		gameMainVC.initView();

		battleHUD.initView();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
