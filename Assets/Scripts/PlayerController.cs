using System.Collections;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 2;
	GameObject cube;
	public Vector3 CubeOffset;
    void Start()
    {
		cube = GameController.I.cubePrefab;
		

		CubeOffset = Vector3.down;
    }

    // Update is called once per frame
    void Update()
    {
		if(Input.GetMouseButton(0))
		{
			float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime;
			transform.Translate(Vector3.right*mouseX*movementSpeed);
		}
		
		transform.Translate(Vector3.forward*Time.deltaTime*movementSpeed);
    }
	
	public void OnCollisionEnter(Collision other)
	{
		var go = other.gameObject;
		
		if(go.tag == "Coin")
		{
			Destroy(go);
			GameController.I.Coin++;
			
			SpawnCube();
		}
		
		if(go.tag == "Trap")
		{
			EditorApplication.isPlaying = false;
		}
	}
	
	public void SpawnCube()
	{
		GameObject go = Instantiate(cube, transform);
		go.transform.localPosition = CubeOffset;
		
		
		transform.Translate(Vector3.up);
		
		CubeOffset += Vector3.down;
	}
}
