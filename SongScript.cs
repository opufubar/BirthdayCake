using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongScript : MonoBehaviour {
	
	// 歌を流す機能をつけるスクリプト
	// 音の発信源にしたい場所（今回はケーキ本体）にアタッチした
	private AudioSource audio;

	void Start () {
		audio = gameObject.GetComponent<AudioSource>();

	}
}
