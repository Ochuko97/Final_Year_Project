using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;

public class Initialise_button : MonoBehaviour {
	//Setting up initilise button
	public Button Startbtn;  
	//Referencing Pedometer Plugin script in order to access functions and variables
	public PedometerPlugin _PedometerPlugin; 


	// get root button componenet for script 
	void Start () {
		Button btn = Startbtn.GetComponent<Button>(); 
		//Add listener to check if button has been clicked 
		btn.onClick.AddListener (TaskOnClick);
	}
	
	// Update is called once button listener has been fired off
	public void TaskOnClick() { 
		//calling to startPedometerService in PedometerPlugin scrip to intilse step counter
		_PedometerPlugin.StartPedometerService(SensorDelay.SENSOR_DELAY_FASTEST);
	} 

} 

