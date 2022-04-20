using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class RoomTemplates : MonoBehaviour {


	public GameObject[] bottomRooms;
	public GameObject[] topRooms;
	public GameObject[] leftRooms;
	public GameObject[] rightRooms;

	public GameObject closedRoom;

	public List<GameObject> rooms;

	public float waitTime;
	private bool spawnedBoss;
	private bool spawnedChest;
	public GameObject boss;
	public int chestRoomSpawn; //declaring public int for user to delare which room they want the chest in
	public GameObject chest;


	









	void Update(){

		if(waitTime <= 0 && spawnedBoss == false){
			for (int i = 0; i < rooms.Count; i++) {
				if(i == rooms.Count-1){
					Instantiate(boss, rooms[i].transform.position, Quaternion.identity);
					spawnedBoss = true;
					
				}
			}
		} else {
			waitTime -= Time.deltaTime;
		}

		if (waitTime <= 0 && spawnedChest == false)
		{
		 for (int i = 0; i < rooms.Count; i++)
			{
				if (i == rooms.Count - 1)
				{
					Instantiate(chest, rooms[chestRoomSpawn].transform.position, Quaternion.identity); //puts the chest into the user determined room based on the code used for boss
					spawnedChest = true;

				}
			}
		}
		else
		{
			waitTime -= Time.deltaTime;
		}



	}
}
