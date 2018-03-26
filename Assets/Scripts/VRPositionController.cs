using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRPositionController : MonoBehaviour {


	public GameObject Player;
	public float MovementSmoothness;

	private Vector3 smoothVelocity;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit) && hit.transform.gameObject.tag == "Ground")
		{
			print(hit.point);
			Debug.DrawLine(gameObject.transform.position, hit.point);
			if(Input.GetMouseButton(0))
			{
				Player.transform.position = Vector3.SmoothDamp(Player.transform.position,hit.point,ref smoothVelocity,MovementSmoothness);
			}
		}


		
    }
}
