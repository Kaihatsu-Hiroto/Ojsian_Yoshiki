using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerMater : MonoBehaviour {

    public Frog m_frog { get;private set; }
    public GameObject m_frogGO;
    public GameObject gage;

    public Image image;
    
    public void Initialize()
    {
        gage = GameObject.Find("p_gage");
        image = gage.GetComponent<Image>();
        image.fillAmount = 0;
    }

    public void UpdateByFrame()
    {
        m_frogGO = GameObject.FindGameObjectWithTag("Player");
        m_frog = m_frogGO.GetComponent<Frog>();

        image.fillAmount = m_frog.power.x / 10;

    }

}
