
	public AudioSource AS;

	void Start () {
		AS = GetComponent<AudioSource> ();
		AS.clip = Microphone.Start ("Logitech USB Headset",false,10,44100);
		AS.Play ();
		foreach (string device in Microphone.devices) {

			Debug.Log (device);

		}

	}
