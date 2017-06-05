using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerGage : MonoBehaviour
{
    public Frog m_frog { get; private set; }

    public void Initialize()
    {
        m_frog = new Frog();
    }
    public void UpdateByFrame()
    {
        //m_frog.transform.localScale = new Vector3(1, m_frog.power.x * 10, 1);
    }

}
