using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;

public class Progress_bar : MonoBehaviour {
	// setting the progress bar fill as a public variable that can be updated through the inspector 
	public Image bar;  
	// public number taht will indicate which percent of the progress bar would be filled
	public float fill_no;  
	public float steps; 



	// Use this for initialization
	void Start () { 
		//setting the variable to zero will cause the progress bar to be empty
		fill_no = 0.0f; 
		//steps 

	}
	
	// Update is called once per frame
	void Update () { 
		// the x scale value of the progress bar will constantly checking for and updating the fill ratio of the progress bar.
		//bar.rectTransform.localScale = new Vector3 (fill_no, 1f, 1f);  
		// this initilse a second routine that will begin when the IEnumerator Updatebar () is called.
		//StartCoroutine(Updatebar());  
		//if the x value of the bar is higher than 1, anchor the value to 1. This ensures the par does not over fill 
		if (fill_no >= 1) {
			fill_no = 1f;
			//Debug.Log("yay"); 
		}
	} 
	//IEnumerator Updatebar ()
	//{
		//Once the coroutine is called wait 2 seconds and increase the bar value.
		//yield return new WaitForSeconds (2.0f); 
		//fill_no += 0.050f; 
	}
//}
