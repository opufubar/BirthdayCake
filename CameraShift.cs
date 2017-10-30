using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShift : MonoBehaviour {

	// ネットから引っ張ってきた
	
	private GameObject MainCam;
	private GameObject SubCam;
	
	
	void Start () {
		
		// カメラ２つのGameObjectを入手して変数に代入
		MainCam = GameObject.Find("MainCamera");
		SubCam = GameObject.Find("SubCamera");
	
		// 始めの状態では２番手のカメラを非アクティブ状態にしておく
		SubCam.SetActive(false);
	}

	void Update () {
		
		// スペースキーを押すと..
		if(Input.GetKeyDown("space")){
			
			// MainCamとSubCamのアクティブ状態を変更する
			if(MainCam.activeSelf){
				MainCam.SetActive (false);	
				SubCam.SetActive (true);
			}else{
				MainCam.SetActive (true);
				SubCam.SetActive (false);
			}
		}
	}


}
