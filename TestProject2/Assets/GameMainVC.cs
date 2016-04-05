using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class GameMainVC : MonoBehaviour {

	public	Button[]	btns;


	public void initView() {

	}

	public void openView() {
		for (int i=0; i<btns.Length; i++) {
			btns[i].gameObject.SetActive(true);
		}

		updateView();
	}

	public void updateView() {


	}

	public void closeView() {		
		for (int i=0; i<btns.Length; i++) {
			btns[i].gameObject.SetActive(false);
		}
	}

}
