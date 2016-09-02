using UnityEngine;
using System.Collections;

public class zombiewalk : MonoBehaviour {
	public Transform player;
	private float moveSpeed = 3f;
	public GameObject target;

	// Update is called once per frame
	void Update () {
		float move = moveSpeed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, player.position, move);
		Vector3 n = target.transform.position - transform.position;
		transform.rotation = Quaternion.LookRotation (n);
	}
}
