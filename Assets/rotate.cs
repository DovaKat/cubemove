using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	public float speed = 60f;
	float angle = 0f;
	

	
	// Update is called once per frame
	void Update () {
		angle = angle + Time.deltaTime * speed;
		transform.rotation = Quaternion.Euler (0f, angle, 0f);
	
	}
}
