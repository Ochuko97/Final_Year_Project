using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;

public class Progress_bar : MonoBehaviour {
	// setting the progress bar fill as a public variable that can be updated through the inspector 
	public Image bar;  
	// utilising the pedometer connect script to transfer my stepcount varriable to this script. 
    public PedometerConnect PedometerConnection;
    // interger I will be using as the numeric value for the progeress bar scipt 
	public int CurrentSteps;
	// the target amout of steps it will take to complete the progress bar in the demo
    public int TargetSteps = 100;
    // the float that will be utilised to interact with the progress bar fill
	public float Progress; 
	//step text box
	public Text Stepbox;

	// Use this for initialization
	void Start () { 

	}
	
	// Update is called once per frame
	void Update () { 
		// settiong the value of the current steps as the value of the step count interger in the pedometer connection scrip 
        CurrentSteps = PedometerConnection.StepCount;  
		//CurrentSteps += 1; 
		//Text box showcases the amount of steps taken
		Stepbox.text = CurrentSteps.ToString (); 
		//freezes current steps once targer as been reached
		if (CurrentSteps >= TargetSteps) {
			CurrentSteps = TargetSteps;
		}
		// setting the progree float as the minimal value from the current steps divided by the target steps ( x/100 = 0.progress) 
        Progress = Mathf.Min((float)CurrentSteps / (float)TargetSteps, 1f);
		//transforming the x value of the progress bar based on the steps taking by the players. 
		bar.rectTransform.localScale = new Vector3(Progress, 1f, 1f);
    } 
}
