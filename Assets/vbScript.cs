using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbScript : MonoBehaviour, IVirtualButtonEventHandler {

	private GameObject vbButtonObject;
	private GameObject zombie;

	// Use this for initialization
	void Start () {

		vbButtonObject = GameObject.Find ("actionButton");
		zombie = GameObject.Find ("Zombie");
		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) {
		zombie.GetComponent<Animation> ().Play ();
//		Debug.Log("Pressed...");
	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) {
		zombie.GetComponent<Animation> ().Stop ();
	}

}