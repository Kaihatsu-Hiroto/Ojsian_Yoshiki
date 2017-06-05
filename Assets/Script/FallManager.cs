using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallManager : MonoBehaviour {

    public FallController m_fallController { set; private get; }

    public GameObject fallLeaf;

    

    public void Initialize()
    { 
       m_fallController = Instantiate(Resources.Load<GameObject>("Prehub/FallLeaf"), transform.position, Quaternion.identity).GetComponent<FallController>();
    }

    public void UpdateByFrame()
    {
        m_fallController.UpdateByFrame();
    }
}
