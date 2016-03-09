using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Chart : MonoBehaviour {
	public Image image;
	void Start () {
		image.fillAmount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (image.fillAmount < 1) {
			image.fillAmount += 0.01f;
		} else {
			image.fillAmount = 0;
		}

	}
}
