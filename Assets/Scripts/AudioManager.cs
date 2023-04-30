using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	public AudioSource bgmAudioSource;
	public GameObject bumperSFX;
	public GameObject planeOnSFX;
	public GameObject planeOffSFX;

	private void Start()
	{
		PlayBGM();
	}

	public void PlayBGM() {
		bgmAudioSource.Play();
	}

	public void PlayBumperSFX(Vector3 spawnPosition) {
		GameObject.Instantiate(bumperSFX, spawnPosition, Quaternion.identity);
	}

	public void PlayPlaneOnSFX(Vector3 spawnPosition)
    {
		GameObject.Instantiate(planeOnSFX, spawnPosition, Quaternion.identity);
    }

	public void PlayPlaneOffSFX(Vector3 spawnPosition)
	{
		GameObject.Instantiate(planeOffSFX, spawnPosition, Quaternion.identity);
	}
}