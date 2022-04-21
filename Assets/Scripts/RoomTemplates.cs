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
	public int chestRoomSpawn; //declaring public int set randomly by the script




	public List<GameObject> chests;

	public int selectedChest;


	public int currentNumberofChests, maxNumberOfChests; //holds the current number and maximum number of chests spawned

  




    void randomizechest ()
    {
		selectedChest = Random.Range(0, chests.Count); //this method chooses a random object image that the user has put into the chests list
	
    }





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

		if (waitTime <= 0 && currentNumberofChests < maxNumberOfChests)
		{
		 for (int i = 0; i < rooms.Count; i++)
			{
				if (i == rooms.Count - 1)
				{
					randomizechest(); //calls that that method in
					chestRoomSpawn = Random.Range(0, rooms.Count - 1); //tracks from 0 to the max number of rooms it is spawned into

					
					Instantiate(chests[selectedChest], rooms[chestRoomSpawn].transform.position, Quaternion.identity, rooms[chestRoomSpawn].transform); //puts the chest into a random room in the same that the boss

					


					currentNumberofChests++;

				}
			}
		}




		else
		{
			waitTime -= Time.deltaTime;
		}


		





	}
}
