using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
	public GameObject bumperVFX;
	public GameObject switchVFX;

	public void PlayBumperVFX(Vector3 spawnPosition)
	{
		GameObject.Instantiate(bumperVFX, spawnPosition, Quaternion.identity);
	}

	public void PlayPlaneVFX(Vector3 spawnPosition)
	{
		GameObject.Instantiate(switchVFX, spawnPosition, Quaternion.identity);
	}
}
