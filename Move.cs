using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	
	// １フレームごとにz方向へ−0.02ずつ移動する
	// HAPPY BIRTHDAY の文字にアタッチしたスクリプト
	void Update () {
		transform.position += new Vector3 (0, 0, - 0.02f);
	}
}
