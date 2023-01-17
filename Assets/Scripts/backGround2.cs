using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backGround2 : MonoBehaviour
{

	private float multiplier;
	//private float multiplierY;
	private GameObject Player;

	void Start()
	{
		Player = GameObject.Find("BabaYaga");
	}

	void Update()
	{
		multiplier = (Player.transform.position.x - 300) / 4;
		//multiplierY = (Player.transform.position.y - 40) / 5;
		transform.position = new Vector3(Player.transform.position.x - multiplier, 15.0F, 0);
	}
}