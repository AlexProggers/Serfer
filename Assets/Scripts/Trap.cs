using System.Collections;
using UnityEditor;
using UnityEngine;

public class Trap : MonoBehaviour
{
    // Start is called before the first frame update
	public void OnTriggerEnter(Collider other)
	{
		var go = other.gameObject;
		
		if(go.GetComponent<CapsuleCollider>())
		{
			EditorApplication.isPlaying = false;
		}
		
		if(go.tag == "Coin")
		{
			Destroy(go);
			
			GameController.I.Coin -= 1;
			GameController.I.Coin = Mathf.Clamp(GameController.I.Coin, 0, 999);
			GameController.I.Player.CubeOffset += Vector3.up;
			
			if(GameController.I.Coin == 0)
			{
				Vector3 playerPos = new Vector3(
					GameController.I.Player.transform.position.x, 
					1.0f, 
					GameController.I.Player.transform.position.z
				);
				
				GameController.I.Player.transform.position = playerPos;
			}
			
			Camera.main.transform.Translate(Vector3.down);
		}
	}
}
