using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTrigger : MonoBehaviour
{
	public void OnTriggerStay(Collider other)
	{
		if(other.tag == "Player")
		{
			other.transform.Rotate(Vector3.down
				* GameController.I.Player.movementSpeed / 10.0f);
		}
	}
}
