using UnityEngine;
using System.Collections;

public class BattleTouchManager : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetMouseButtonDown(0)) {
			g.bm.bcm.ActiveSwing(c.LEFT);
		}
		else if (Input.GetMouseButtonDown(1)) {	
			g.bm.bcm.ActiveSwing(c.RIGHT);	
			
		}
	}
}
