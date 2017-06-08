using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrocodileController : MonoBehaviour {

    public Frog m_frog { get; private set; }

    public bool GameEnd = false;

    public void Initialize()
    {

    }

    public void UpdateByFrame()
    {
        m_frog = new Frog();

        Vector3 WaniPos = FrogManager.Instance.
            m_frogController.m_frog.transform.position;

        if (WaniPos.x < 0)
            transform.position = new Vector3(WaniPos.x, -11, -3);

        if (WaniPos.x > 0)
        {
            transform.position = new Vector3(WaniPos.x, -11, -3);
        }
        if (WaniPos.y < -5)
        {
            transform.position = new Vector3(WaniPos.x, -4, -3);
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        GameEnd = true;
        
    }

}
