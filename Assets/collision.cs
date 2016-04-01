using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour {

    public bool tags;
    
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider collision)
    {
        if (tags == true)
        {
            tags = false;
        }
        else if (tags == false)
        {
            tags = true;
        }
    }
}
