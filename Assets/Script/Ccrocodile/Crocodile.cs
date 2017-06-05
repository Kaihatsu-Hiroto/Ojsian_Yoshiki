using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crocodile : MonoBehaviour {

    public Frog m_frog { get;private set;}
    // Use this for initialization
    


    // Update is called once per frame


    void UpdateByFrame()
    {
        m_frog = new Frog();

        Vector3 WaniPos = FrogManager.Instance.
            m_frogController.m_frog.transform.position;

        

        //  WaniPos.x -= 5;

        if (WaniPos.x < 0)
            transform.position = new Vector3(WaniPos.x, -11, -3);
            
        if (WaniPos.x > 0)
        {
            transform.position = new Vector3(WaniPos.x, -11, -3);
        }
        if (WaniPos.y < -5)
        {
            transform.position = new Vector3(WaniPos.x,WaniPos.y+1, -3);
            
            
        }
      
       
       
    }

    void Start()
    {

    }
    void Update()
    {
        UpdateByFrame();
        
        
    }
}

