using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedometerConnect : MonoBehaviour {

    private PedometerPlugin pedometerPlugin;
    private string demoName = "[PedometerDemo] ";
    private UtilsPlugin utilsPlugin;

    private int stepCount = 0;
    public int StepCount { get { return stepCount; } }

    // Use this for initialization
    void Start () {
        //get the instance of pedometer plugin
        pedometerPlugin = PedometerPlugin.GetInstance();

        //set to zero to hide debug toast messages
        pedometerPlugin.SetDebug(0);

        utilsPlugin = UtilsPlugin.GetInstance();
        utilsPlugin.SetDebug(0);

        //check if step detector is supported on the current android mobile device
        bool hasStepDetector = utilsPlugin.HasStepDetector();
        bool hasStepCounter = utilsPlugin.HasStepCounter();

        //if (hasStepDetector) {
        if (hasStepCounter) {
            pedometerPlugin.OnStepCount += OnStepCount;

            //initialze pedometer
            pedometerPlugin.Init();
        }
    }
	public void StartPedometerService ()
	{
		// here you start and pass the sensor delay that you want to use
		pedometerPlugin.StartPedometerService (SensorDelay.SENSOR_DELAY_FASTEST);
		Debug.Log (demoName + "StartPedometerService has been called");
	} 
	public void StopPedometerService ()
	{
		pedometerPlugin.StopPedometerService ();
	}

    private void OnStepCount(int totalStepCount) {
        stepCount++;
    }
}
