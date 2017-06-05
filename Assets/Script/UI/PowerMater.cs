using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerMater : MonoBehaviour {

    public Frog m_frog { get; private set; }
    GameObject gage;

    public Image image;


    
    public void Initialize()
    {
        m_frog = new Frog();
        gage = GameObject.Find("p_gage");
        image = GetComponent<Image>();
        image.fillAmount = 0;
    }

    public void UpdateByFrame()
    {

        //image.fillAmount = m_frog.power.x;
        image.fillAmount += 0.01f; 
      
    }

    void Start()
    {
        //m_frog.power.x = m_frog.power.x * 1f;
       

    }
    void Update()
    {
        UpdateByFrame();
    }
}
