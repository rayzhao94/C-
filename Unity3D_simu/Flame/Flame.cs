using UnityEngine;
using System.Collections;

public class Flame : MonoBehaviour {
	
	public float soundEffectVolume = 1.0f;	
	public bool _isActive = false;	
	
	private Transform _cacheTransform;	
	private Light _cacheLight;
	private ParticleSystem _cacheParticleSystem;
	
	public void StartFlame()
	{		
		_isActive = true; 
	}	
	
	public void StopFlame()
	{		
		_isActive = false; 
	}
	
	// Use this for initialization
	void Start ()
	{			
		_cacheTransform = transform;	
		
		// Cache the light source to improve performance (also ensure that the light source in the prefab is intact.)
		_cacheLight = transform.GetComponent<Light>().light;
		if (_cacheLight == null) {
			Debug.LogError("Flame prefab has lost its child light. Recreate the flame using the original prefab.");
		}
		
		// Cache the particle system to improve performance (also ensure that the particle system in the rpefab is intact.)
		_cacheParticleSystem = particleSystem;
		if (_cacheParticleSystem == null) {
			//Debug.LogError("Flame has no particle system. Recreate the flame using the original prefab.");
		}
		
		// Start the audio loop playing but mute it. This is to avoid play/stop clicks and clitches that Unity may produce.
		audio.loop = true;
		audio.volume = soundEffectVolume;
		audio.mute = true;
		audio.Play();
	
	}
	
	// Update is called once per frame
	void Update ()
	{	
		if (_cacheLight != null) {			
			_cacheLight.intensity = _cacheParticleSystem.particleCount / 20;
		}
		
		// If the thruster is active...
		if (_isActive) {
			// ...and if audio is muted...
			if (audio.mute) {
				// Unmute the audio
				audio.mute=false;
			}
			// If the audio volume is lower than the sound effect volume...
			if (audio.volume < soundEffectVolume) {
				// ...fade in the sound (to avoid clicks if just played straight away)
				audio.volume += 5f * Time.deltaTime;
			}
			
			// If the particle system is intact...
			if (_cacheParticleSystem != null) {	
				// Enable emission of thruster particles
				_cacheParticleSystem.enableEmission = true;
			}		
		} else {
			// The thruster is not active
			if (audio.volume > 0.01f) {
				// ...fade out volume
				audio.volume -= 5f * Time.deltaTime;	
			} else {
				// ...and mute it when it has faded out
				audio.mute = true;
			}
			
			// If the particle system is intact...
			if (_cacheParticleSystem != null) {				
				// Stop emission of thruster particles
				_cacheParticleSystem.enableEmission = false;				
			}
			
		}
	}
}
