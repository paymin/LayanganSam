using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour {

	public GameObject[] tilePrefabs;

	private Transform playerTransform;
	private float spawnY = 4f;
	private float tileLength = 14.5f;
	private float safeZone = 14.0f;
	private int amnTilesOnScreen = 3;
	private int lastPrefabIndex = 0;
	private int x, y;


	private List<GameObject> activeTiles;

	// Use this for initialization
	private void Start () {
		activeTiles = new List<GameObject> ();
		playerTransform = GameObject.FindGameObjectWithTag ("Player").transform;


		for (int i = 0; i < 3; i++) {
			if (i < 1) {
				SpawnTile (0);
			}
			else {
				SpawnTile(1);
			}
			//SpawnTile (0);
		} 



				/*if (i < 60) {
					SpawnTile ();
				}
			}
			else {
				SpawnTile ();
			}
			SpawnTile (1);
		}*/


	}
	
	// Update is called once per frame
	private void Update () {
		

		if (playerTransform.position.y - safeZone > (spawnY - amnTilesOnScreen * tileLength)) {
			SpawnTile (y);
			print (x);
			DeleteTile ();
			x += 1;
		} 


		if (x < 1) {
			y = 1;
		} else if (x < 2) {
			y = 2;
		} else if (x < 4) {
			y = 3;
		} else if (x < 5) {
			y = 4;
		} else if (x < 7) {
			y = 5;
		} else if (x < 8) {
			y = 6;
		} else if (x < 10) {
			y = 7;
		} else if (x < 11) {
			y = 8;
		} else {
			y = 9;
		}


	}

	private void SpawnTile(int prefabIndex = -1){
		GameObject go;
		if (prefabIndex == -1)
			go = Instantiate (tilePrefabs [RandomPrefabIndex ()]) as GameObject;
		else
			go = Instantiate (tilePrefabs [prefabIndex]) as GameObject;
		go.transform.SetParent (transform);
		go.transform.position = Vector3.up * spawnY;
		spawnY += tileLength;
		activeTiles.Add (go);
	}

	private void DeleteTile(){
		Destroy (activeTiles [0]);
		activeTiles.RemoveAt (0);
	}

	private int RandomPrefabIndex(){
		if (tilePrefabs.Length <= 1) {
			
			return 0;
		}
			

		int randomIndex = lastPrefabIndex;
		while (randomIndex == lastPrefabIndex) {
			randomIndex = Random.Range (3,tilePrefabs.Length);
		}

		lastPrefabIndex = randomIndex;
		return randomIndex;
	}
}
