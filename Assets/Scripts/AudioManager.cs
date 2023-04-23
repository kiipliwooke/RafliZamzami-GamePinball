using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	public AudioSource bgmAudioSource;
	public GameObject bumperSFX;
	public GameObject planeSFX;
	
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

	public void PlayPlaneSFX(Vector3 spawnPosition)
    {
		GameObject.Instantiate(planeSFX, spawnPosition, Quaternion.identity);
    }
}