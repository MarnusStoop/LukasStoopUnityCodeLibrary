using UnityEngine;
using System.Collections;

public class AudioManager
{

	private float musicVolume;

	public float MusicVolume {
		get {
			return musicVolume;
		}
		set {
			musicVolume = value;
		}
	}

	private float sfxVolume;

	public float SfxVolume {
		get {
			return sfxVolume;
		}
		set {
			sfxVolume = value;
		}
	}

	private float voiceVolume;

	public float VoiceVolume {
		get {
			return voiceVolume;
		}
		set {
			voiceVolume = value;
		}
	}

	public AudioManager(float _musicVolume = 100f, float _sfxVolume = 100f, float _voiceVolume = 100f)
	{
		this.MusicVolume = _musicVolume;
		this.SfxVolume = _sfxVolume;
		this.VoiceVolume = _voiceVolume;
	}

}