using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crocodile : MonoBehaviour {

    public Frog m_frog { get;private set;}
	// Use this for initialization

	
	// Update is called once per frame

	
    void UpdateByFrame()
    {
        Vector3 WaniPos = FrogManager.Instance.
            m_frogController.m_frog.transform.position;

        if (WaniPos.x < 0)
            transform.position = new Vector3(WaniPos.x + 5, 0, -10);

        if (WaniPos.x > 0)
        {
            transform.position = new Vector3(WaniPos.x + 5, 0, -10);
        }
    }
}

