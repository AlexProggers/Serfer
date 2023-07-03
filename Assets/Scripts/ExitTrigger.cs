using System.Collections;
using UnityEditor;
using UnityEngine;

public class ExitTrigger : MonoBehaviour
{
	public void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			EditorApplication.isPlaying = false;
		}
	}
}
