using UnityEngine;
using System.Collections;

public class explode : MonoBehaviour {


    void OnTriggerEvent(Collider boom)
    {
        Destroy(gameObject);
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
