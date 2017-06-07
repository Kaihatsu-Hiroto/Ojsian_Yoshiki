using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerMater : MonoBehaviour {

    public Frog m_frog { get; set; }
    public GameObject m_frogGO;
    public GameObject gage;

    public Image image;


    
    public void Initialize()
    {
       
    }

    public void UpdateByFrame()
    {
        m_frogGO = GameObject.FindGameObjectWithTag("Player");
        m_frog = m_frogGO.GetComponent<Frog>();
        image.fillAmount = m_frog.power.x / 10;
        //m_frog.power.x = m_frog.power.x * 1f;
        //image.fillAmount += 0.01f; 

    }

    void Start()
    {
        //m_frog = new Frog();
        
        gage = GameObject.Find("p_gage");
        image = gage.GetComponent<Image>();
        image.fillAmount = 0;
        
       

    }
    void Update()
    {
        UpdateByFrame();
    }
}
