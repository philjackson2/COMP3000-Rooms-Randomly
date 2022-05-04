using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class RoomTemplates : MonoBehaviour {


	public GameObject[] bottomRooms;
	public GameObject[] topRooms;
	public GameObject[] leftRooms;
	public GameObject[] rightRooms;

	public GameObject closedRoom;

	public List<GameObject> rooms; //included as spawned rooms will be added to the list which enables tracking

	public float waitTime;
	private bool spawnedBoss;
	private bool spawnedChest;
	private bool spawnedEnemies;
	public GameObject boss;
	



	public List<GameObject> chests;
	public int chestRoomSpawn; //declaring public int set randomly by the script
	public int selectedChest;
	public int currentNumberofChests, maxNumberOfChests; //holds the current number and maximum number of chests spawned



	public List<GameObject> enemies;
	public int enemyRoomSpawn;
	public int selectedEnemies;
	public int currentNumberofEnemies, maxNumberOfEnemies;


	#region random number range 

	void randomizechest ()
    {
		selectedChest = Random.Range(0, chests.Count); //this method chooses a random object  that the user has put into the chests list
	
    }

	void randomizeEnemies()
	{
		selectedEnemies = Random.Range(0, enemies.Count); //this method chooses a random object  that the user has put into the chests list

	}

	#endregion

	void Update(){
        #region boss spawn
        if (waitTime <= 0 && spawnedBoss == false){
			for (int i = 0; i < rooms.Count; i++) {
				if(i == rooms.Count-1){
					Instantiate(boss, rooms[i].transform.position, Quaternion.identity);
					spawnedBoss = true;
					
				}
			}
		} else {
			waitTime -= Time.deltaTime;
		}
        #endregion


        #region chest spawn
        if (waitTime <= 0 && currentNumberofChests < maxNumberOfChests)
		{
		 for (int i = 0; i < rooms.Count; i++)
			{
				if (i == rooms.Count - 1)
				{
					randomizechest(); //calls that that method in
					chestRoomSpawn = Random.Range(0, rooms.Count - 1); //tracks from 0 to the max number of rooms it is spawned into
					Instantiate(chests[selectedChest], rooms[chestRoomSpawn].transform.position + new Vector3(Random.Range(2, -2), Random.Range( 2, -2), 0), Quaternion.identity, rooms[chestRoomSpawn].transform); //puts the chest into a random room in the same that the boss
					//using new Vector 3 and the functions within to randomize the loocation of the chests within the rooms in order to stop items spawning on top of eachother
					


					currentNumberofChests++; //++ to increament 

				}
			}
		}

		else
		{
			waitTime -= Time.deltaTime;
		}
        #endregion



        #region enemie spawn

        if (waitTime <= 0 && currentNumberofEnemies < maxNumberOfEnemies)
		{
			for (int i = 0; i < rooms.Count; i++)
			{
				if (i == rooms.Count - 1)
				{
					randomizeEnemies(); //calls that that method in
					enemyRoomSpawn = Random.Range(0, rooms.Count - 1); //tracks from 0 to the max number of rooms it is spawned into
					Instantiate(enemies[selectedEnemies], rooms[enemyRoomSpawn].transform.position + new Vector3(Random.Range(2, -2), Random.Range(2, -2), 0), Quaternion.identity, rooms[enemyRoomSpawn].transform); 
																																																			



					currentNumberofEnemies++; //++ to increament 

				}
			}
		}

			else
		{
			waitTime -= Time.deltaTime;
		}


		#endregion





	}
}
