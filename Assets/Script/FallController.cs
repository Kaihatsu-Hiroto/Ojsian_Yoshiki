using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallController : MonoBehaviour {

    public GameObject obj;

    Vector3 SPEED = new Vector3(0, 0.01f);

    bool falling = false;

    Vector3 RestartPos; 

    public void Initialize()
    {
        obj = GameObject.Find("FallLeaf");
        RestartPos = obj.transform.position; 
    }

	public void UpdateByFrame()
    {

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        
    }

    void Fall()
    {
        Debug.Log("Falling");
        Vector3 Pos = obj.transform.position;
        Pos.y -= SPEED.y;
        obj.transform.position = Pos;
    }
    void RetrunTo()
    {
        //if(obj.transform.position.y < RestartPos.y)
        //obj.transform.position += SPEED;
    }


}
