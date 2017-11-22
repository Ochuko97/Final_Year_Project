using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;

public class Progress_bar : MonoBehaviour {
	// setting the progress bar fill as a public variable that can be updated through the inspector 
	public Image bar;  
	
    public PedometerConnect PedometerConnection;
    public int CurrentSteps;

    public int TargetSteps = 100;
    public float Progress;

	// Use this for initialization
	void Start () { 

	}
	
	// Update is called once per frame
	void Update () { 
		// the x scale value of the progress bar will constantly checking for and updating the fill ratio of the progress bar.
		// 
		// this initilse a second routine that will begin when the IEnumerator Updatebar () is called.
		//StartCoroutine(Updatebar());  
		//if the x value of the bar is higher than 1, anchor the value to 1. This ensures the par does not over fill 

        CurrentSteps = PedometerConnection.StepCount;
        Progress = Mathf.Min((float)CurrentSteps / (float)TargetSteps, 1f);
        bar.rectTransform.localScale = new Vector3(Progress, 1f, 1f);
    } 
	//IEnumerator Updatebar ()
	//{
		//Once the coroutine is called wait 2 seconds and increase the bar value.
		//yield return new WaitForSeconds (2.0f); 
		//fill_no += 0.050f; 
	}
//}
