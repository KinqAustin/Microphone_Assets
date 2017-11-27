using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MP : MonoBehaviour {

	public AudioSource AS;

	void Start () {
		AS = GetComponent<AudioSource> ();
		AS.clip = Microphone.Start ("Logitech USB Headset",false,10,44100);
		AS.Play ();
		foreach (string device in Microphone.devices) {

			Debug.Log (device);

		}

	}
	

}
