using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerGage : MonoBehaviour
{
    public Frog m_frog { get; private set; }
    GameObject gage;


    public void Initialize()
    {
        m_frog = new Frog();
        gage = GameObject.Find("Gage");
    }

    public void UpdateByFrame()
    {
        gage.transform.localScale = new Vector3(  1, m_frog.power.x * 10, 1);
    }

}
