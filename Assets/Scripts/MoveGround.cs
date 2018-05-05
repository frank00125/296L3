using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGround : MonoBehaviour {
	
	public GameObject[] ground;
	public float speed = 0;

	void Update () {
		for(int i=0;i<ground.Length;i++){
			if(ground[i].transform.position.x <= -64){
				if(i != ground.Length - 1){
					ground[i].transform.position = ground[i+1].transform.position + new Vector3(63, 0, 0);
				}
				else if(i == ground.Length - 1){
					ground[i].transform.position = ground[0].transform.position + new Vector3(63, 0, 0);
				}
			}
			else{
				ground[i].transform.Translate(Vector3.left * speed * Time.deltaTime);
			}
		}
	}
}
