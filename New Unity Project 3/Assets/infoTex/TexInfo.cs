using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TexInfo: MonoBehaviour {

	public Text text;

	void Start () {

	}
	// Update is called once per frame
	void Update () {
		int i = Random.Range (100000, 10000000);
		text.text =""+i; 
	}
}
