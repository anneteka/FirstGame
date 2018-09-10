
using UnityEngine;

public class CameraMove : MonoBehaviour
{

	public GameObject player;
	// Update is called once per frame
	void Start()
	{
		//player = GameObject.Find("player");
	}
	void Update ()
	{
		transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -5f);
	}
}
