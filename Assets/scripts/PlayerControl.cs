using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public Transform player;

	Player ps;

	void Awake ()
	{
		ps = player.GetComponent<Player>();
	}

	void Start () {
		print ("got into playercontrol");
	}

	void Update () {
		Movement1();
	}

	void Movement1()
	{
		if (Input.GetKeyDown("space")){
			ps.Jump();
		}
	}

}
