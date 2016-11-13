using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Controller : NetworkBehaviour {

	// Update is called once per frame
	void Update () {
        if (!isLocalPlayer)
        {
            return;
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Transform>().position = new Vector3(GetComponent<Transform>().position.x +0.51f, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z); 
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Transform>().position = new Vector3(GetComponent<Transform>().position.x - 0.5f, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z);
        }
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Transform>().position = new Vector3(GetComponent<Transform>().position.x , GetComponent<Transform>().position.y , GetComponent<Transform>().position.z + 0.51f);
        }
        if ( Input.GetKey(KeyCode.S))
        {
            GetComponent<Transform>().position = new Vector3(GetComponent<Transform>().position.x , GetComponent<Transform>().position.y, GetComponent<Transform>().position.z - 0.51f);
        }
	}
}
