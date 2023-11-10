using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour
{
	//PSEUDO CODE: Declare public variable of type float for speed;
    public float speed = 50.0f;
	
	void OnMouseDrag()
	{
		//TRY:
		// Declare and Initialize the X and Y mouse axes and multiply by speed.
		// The value is in the range -1 to 1
        //Mouse Y will become Z translation
        float transX = Input.GetAxis("Mouse X") * speed;
		float transZ = Input.GetAxis("Mouse Y") * speed;

		// Make translation variable move at 10 meters per second instead of 10 meters per frame with TimeDeltaTime...
        transX *= Time.deltaTime;
		transZ *= Time.deltaTime;

		// use transform to translate with values above
		////Move translation along the object's x abd z-axis
		transform.Translate(transX, 0, transZ);

		//Try Stretch Task in tutorial sheet

	}
}

//From: https://docs.unity3d.com/ScriptReference/Input.GetAxis.html
