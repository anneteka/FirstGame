using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dying : MonoBehaviour
{
	public GameObject player;
	public GameObject respawn;
	void OnTriggerEnter2D(Collider2D other)
	{
	if (	other.gameObject.Equals(player))
	//	if (CompareTag("Player"))
		{
			other.transform.position = respawn.transform.position;
		}
	}
}
