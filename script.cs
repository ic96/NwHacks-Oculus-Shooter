using UnityEngine;
using System.Collections;

public class script : MonoBehaviour {

	public GameObject[] enemies;
	public int amount;
	private Vector3 spawnPoint;
	
	// Update is called once per frame
	void Update () {
		amount = enemies.Length;
		if (amount != 10) {
			InvokeRepeating ("spawnEnemy", 1, 1f);
		}
	}

	void spawnEnemy () {
		spawnPoint.x = Random.Range (-20, 20);
		spawnPoint.y = 1f;
		spawnPoint.z = Random.Range (-20, 20);
		Instantiate (enemies [UnityEngine.Random.Range (0, enemies.Length - 1)], spawnPoint, Quaternion.identity);
		CancelInvoke ();
	}
}
