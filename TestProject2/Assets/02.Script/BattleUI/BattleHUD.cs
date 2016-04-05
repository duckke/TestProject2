using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BattleHUD : MonoBehaviour {
	public	Text	text_bestScore;
	public	Text	text_bestScoreValue;
	public	Text	text_curScoreValue;

	//
	public	Text	text_frameRateValue;


	public void initView() {
		StartCoroutine("PrintFrameRate");
	}
	public void openView() {
		this.updateView();
	}
	public void updateView() {

	}
	public void closeView() {

	}
	
	IEnumerator PrintFrameRate() {
		while(text_frameRateValue.gameObject != null) {
			text_frameRateValue.text = string.Format("{0:#.0}FPS",(Mathf.Round((1.0f/Time.deltaTime)/0.1f)*0.1f));
			yield return new WaitForSeconds(0.2f);
		}
	}

}
