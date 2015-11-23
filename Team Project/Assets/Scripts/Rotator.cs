using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	public int speed = 2;
	
	void Update () {
		transform.Rotate (new Vector3 (0, 15, 0) * Time.deltaTime * speed);
	}
}
