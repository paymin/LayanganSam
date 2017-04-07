using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Max : MonoBehaviour {
	
	public GameObject[] tilePrefabs;

	private Transform playerTransform;
	private float spawnY = 0.0f;
	private float tileLength = 11f;
	private float safeZone = 16.0f;
	private int amnTilesOnScreen = 3;
	private int lastPrefabIndex = 0;
	private int x, y;

	private List<GameObject> activeTiles;

	// Use this for initialization
	private void Start () {
		activeTiles = new List<GameObject> ();
		playerTransform = GameObject.FindGameObjectWithTag ("Player").transform;

		for (int i = 0 ; i < amnTilesOnScreen; i++) {
			if (i < 1) {
				SpawnTile (Random.Range (0, 6));
			}
			else {
				SpawnTile(1);
			}
		}


	}

	// Update is called once per frame
	private void Update () {
		if (playerTransform.position.y - safeZone > (spawnY - amnTilesOnScreen * tileLength)){
			print ("asemy" + y);
			print ("asemx" + x);
			SpawnTile (y);
			DeleteTile ();
			x += 1;
		} 


		if (x < 10) {
			y = Random.Range (0, 6);
		} else {
			y = -1;
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
		if (tilePrefabs.Length < 1) {

			return 0;
		}


		int randomIndex = lastPrefabIndex;
		while (randomIndex == lastPrefabIndex) {
			randomIndex = Random.Range (7, tilePrefabs.Length);
		}

		lastPrefabIndex = randomIndex;
		return randomIndex;
	}
}
