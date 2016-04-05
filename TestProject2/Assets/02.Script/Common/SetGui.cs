using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SetGui : MonoBehaviour {
	public	static	Image[]	images;
	public	static	Text[]	texts;
	public	static	Color	color_enable = Color.white;
	public	static	Color	color_disable = new Color(0.65f, 0.65f, 0.65f);

	public static void SetButtonEnable(Button _button) {
		bool is_inactive = false;
		if (_button.gameObject.activeSelf == false) {
			_button.gameObject.SetActive(true);
			is_inactive = true;
		}
		_button.interactable = true;

		_button.image.color = color_enable;
		
		Image[] imgs = _button.gameObject.GetComponentsInChildren<Image>();
		for (int i=0; i<imgs.Length; ++i) {
			imgs[i].color = new Color(color_enable.r, color_enable.g, color_enable.b, imgs[i].color.a);
		}
		Text[] txts = _button.gameObject.GetComponentsInChildren<Text>();
		for (int i=0; i<txts.Length; ++i) {
			if (txts[i].color == color_enable || txts[i].color == color_disable)
				txts[i].color = new Color(color_enable.r, color_enable.g, color_enable.b, txts[i].color.a);
		}

		if (is_inactive == true) {
			_button.gameObject.SetActive(false);
		}
	}
	
	public static void SetButtonDisable(Button _button) {
		bool is_inactive = false;
		if (_button.gameObject.activeSelf == false) {
			_button.gameObject.SetActive(true);
			is_inactive = true;
		}		
		_button.interactable = false;

		_button.image.color = color_disable;
		
		Image[] imgs = _button.gameObject.GetComponentsInChildren<Image>();
		for (int i=0; i<imgs.Length; ++i) {
			imgs[i].color = new Color(color_disable.r, color_disable.g, color_disable.b, imgs[i].color.a);
		}
		Text[] txts = _button.gameObject.GetComponentsInChildren<Text>();
		for (int i=0; i<txts.Length; ++i) {
			if (txts[i].color == color_enable || txts[i].color == color_disable)
				txts[i].color =  new Color(color_disable.r, color_disable.g, color_disable.b, txts[i].color.a);
		}
		
		if (is_inactive == true) {
			_button.gameObject.SetActive(false);
		}
	}

	public static void SetButton(Button _button, bool flag) {
		if (flag == true)
			SetButtonEnable(_button);
		else
			SetButtonDisable(_button);
	}

	public static void SetButtonTransparent(Button _button, bool flag) {
		if (flag == true){
			_button.interactable = true;
			_button.image.color = new Color(_button.image.color.r, _button.image.color.g, _button.image.color.b, 1f);

//			Text text = _button.GetComponentInChildren<Text>();
//			if (text != null)
//				text.color = new Color(text.color.r, text.color.g, text.color.b, 1f);
		}
		else{
			_button.interactable = false;
			_button.image.color = new Color(_button.image.color.r, _button.image.color.g, _button.image.color.b, 0.5f);

//			Text text = _button.GetComponentInChildren<Text>();
//			if (text != null)
//				text.color = new Color(text.color.r, text.color.g, text.color.b, 0.5f);
		}
	}

	public static void SetImageAlpha(Image _img, float alpha){
		_img.color = new Color(_img.color.r, _img.color.g, _img.color.b, alpha);
	}
}