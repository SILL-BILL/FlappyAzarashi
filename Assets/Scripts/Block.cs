using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

	//隙間の高さ範囲
	public float minHeight; 
	public float maxHeight;
	//Pivotオブジェクト
	public GameObject pivot;

	// Use this for initialization
	void Start () {

		//開始時に隙間の高さを変更(隙間の初期化)
		ChangeHeight();

	}

	void ChangeHeight(){

		//ランダムな高さを生成して設定(高さの変更)
		float height = Random.Range(minHeight, maxHeight);
		pivot.transform.localPosition = new Vector3 (0.0f, height, 0.0f);

	}

	//ScrollObjectスクリプトからのメッセージを受け取って高さを変更
	void OnScrollEnd(){

		//スクロール完了時の隙間の再設定
		ChangeHeight ();

	}
}
