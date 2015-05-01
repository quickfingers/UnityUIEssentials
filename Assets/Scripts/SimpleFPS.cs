using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Text))]
public class SimpleFPS : MonoBehaviour {


	private Text textComponent;
	private int frameCount = 0;
	private float fps = 0;
	private float timeLeft =0.5f;
	private float timePassed = 0f;
	private float updateInterval = 0.5f;
	
	void Awake () {
		textComponent = GetComponent<Text>();
		if(!textComponent) {
			Debug.LogError("this script needs to be attached to a text component!");
			enabled = false;
			return;
		}
	}
	
	void Start () {
	
	}
	

	void Update () {
			frameCount += 1;
			timeLeft -= Time.deltaTime;
			timePassed += Time.timeScale/ Time.deltaTime;
			// FPS CALCULATION
			if(timeLeft<=0f)
			{
				fps = timePassed/frameCount;
				timeLeft = updateInterval;
				timePassed=0f;
				frameCount=0;
			}
			
			if(fps < 30	) {textComponent.color = Color.red;}
			else if(fps < 60) {textComponent.color = Color.yellow;}
			else {textComponent.color = Color.green;}
			textComponent.text = string.Format("{0}: FPS", fps);
	}
}
