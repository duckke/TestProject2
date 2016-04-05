using UnityEngine;
using System.Collections;
using Etc.Classes.Lang;

public class Global : MonoBehaviour {
	public	const	int	MaxCharacterNum = 10;
	public	const	int	MaxMonsterNum = 9;

	[System.Serializable]
	public class user {
		public	int		high_score;
		public	int[]	character; // 0:false, 1:true
	};
	public	user		User;

	[System.Serializable]
	public class monster {
		public	int		model;
		public	float	speed;
		public	int		skill;
	};
	[SerializeField]
	public	monster[]	Monster;


	void Awake() {
		g.gl = this;
	}

	// Use this for initialization
	void Start() {

		this.DataInit();


//		this.SaveInitData();
	}


	private void DataInit() {
		Lang lang = null;

		User = new user();
		User.high_score = PlayerPrefs.GetInt("USER_HIGHSCORE", 0);
		User.character = new int[Global.MaxCharacterNum];
		for (int i=0; i<User.character.Length; i++) {
			User.character[i] = PlayerPrefs.GetInt("USER_CHARACTER_"+i, 0);
		}

		Monster = new monster[MaxMonsterNum];
		for (int i=0; i<MaxMonsterNum; i++) {			
			lang = new Lang("Data/game_data", string.Format("monster_{0}", i));	
			this.Monster[i] = new monster();
			this.Monster[i].model = i;			
			this.Monster[i].speed = float.Parse(lang.getString(string.Format("speed")));
			this.Monster[i].skill = int.Parse(lang.getString(string.Format("skill")));
		}

	}

}
