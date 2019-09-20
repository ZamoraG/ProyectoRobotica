using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotControl_Kuka : MonoBehaviour {
	public float robotJ1SliderValue = 0;
	public float robotJ2SliderValue = 0;
	public float robotJ3SliderValue = 0;
	public float robotJ4SliderValue = 0;
	public float robotJ5SliderValue = 0;
	public float robotJ6SliderValue = 0;

	public Transform RobotJ1;
	public Transform RobotJ2;
	public Transform RobotJ3;
	public Transform RobotJ4;
	public Transform RobotJ5;
	public Transform RobotJ6;

	public float J2TurnRate = 0.4F;
	public float J1TurnRate = 0.4F;
	public float J3TurnRate = 0.4F;
	public float J4TurnRate = 0.4F;
	public float J5TurnRate = 0.4F;
	public float J6TurnRate = 0.4F;

	// Start is called before the first frame update
	void Start () {

	}

	void Update () {
		//rotating our base of the robot here around the Y axis and multiplying
		//the rotation by the slider's value and the turn rate for the base.
		RobotJ1.Rotate (0, robotJ1SliderValue * J1TurnRate, 0);
		RobotJ2.Rotate (0, 0, robotJ2SliderValue * J2TurnRate);
		RobotJ3.Rotate (0, 0, robotJ3SliderValue * J3TurnRate);
		RobotJ4.Rotate (robotJ4SliderValue * J4TurnRate, 0, 0);
		RobotJ5.Rotate (0, 0, robotJ5SliderValue * J5TurnRate);
		RobotJ6.Rotate (robotJ6SliderValue * J6TurnRate, 0, 0);

		if (Input.GetMouseButtonUp (0)) {
			//resets the sliders back to 0 when you lift up on the mouse click down.
			robotJ1SliderValue = 0;
			robotJ2SliderValue = 0;
			robotJ3SliderValue = 0;
			robotJ4SliderValue = 0;
			robotJ5SliderValue = 0;
			robotJ6SliderValue = 0;
		}
	}

	void OnGUI () {
		//creates the slider and sets it 25 pixels in x, 25 in y, 100 wide and 30 tall.
		robotJ1SliderValue = GUI.HorizontalSlider (new Rect (25, 25, 100, 30), robotJ1SliderValue, -10.0F, 10.0F);
		robotJ2SliderValue = GUI.HorizontalSlider (new Rect (25, 80, 100, 30), robotJ2SliderValue, -10.0F, 10.0F);
		robotJ3SliderValue = GUI.HorizontalSlider (new Rect (25, 135, 100, 30), robotJ3SliderValue, -10.0F, 10.0F);
		robotJ4SliderValue = GUI.HorizontalSlider (new Rect (25, 190, 100, 30), robotJ4SliderValue, -10.0F, 10.0F);
		robotJ5SliderValue = GUI.HorizontalSlider (new Rect (25, 245, 100, 30), robotJ5SliderValue, -10.0F, 10.0F);
		robotJ6SliderValue = GUI.HorizontalSlider (new Rect (25, 300, 100, 30), robotJ6SliderValue, -10.0F, 10.0F);

	}
}