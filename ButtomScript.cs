using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtomScript : MonoBehaviour {
	// ボタンを押すとシーンがmain2に切り替わる
	public void SceneLoad(){
		Application.LoadLevel("main2");
	}
}
