using UnityEngine;
using System.Collections;
using UnityEngine.UI;

	public class TextBox : MonoBehaviour {
	int count=0;
	public Text text;
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		count++;
		if(count<250){
			int i = Random.Range (0, 9);
			text.text +=""+i; 
		}
	}

}
