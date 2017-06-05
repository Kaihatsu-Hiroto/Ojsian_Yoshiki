using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallController : MonoBehaviour {

    GameObject obj;

    Vector3 SPEED = new Vector3(0, 0.1f);

    bool FALLING = false;

    Vector3 RestartPos; 
   

    public void Initialize()
    {

        RestartPos = obj.transform.position; 
    }

	public void UpdateByFrame()
    {
        if (FALLING)
        {
            Fall();
        }
        //else
        //{
        //    RetrunTo();
        //}
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        
        FALLING = true;
    }

    void Fall()
    {
        obj.transform.position -= SPEED;
    }
    void RetrunTo()
    {
        //if(obj.transform.position.y < RestartPos.y)
        //obj.transform.position += SPEED;
    }


}
