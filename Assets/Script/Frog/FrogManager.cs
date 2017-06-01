using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogManager : MonoBehaviour {

    /// <summary>
    /// Singleton
    /// </summary>
    private static FrogManager m_instance;

    public static FrogManager Instance
    {
        get
        {
            if (m_instance == null)
            {
                m_instance = new GameObject("Frogs").AddComponent<FrogManager>();
            }
            return m_instance;
        }
    }

    private FrogManager() { }

    public FrogController m_frogController { get; private set; }

    public void Initialize()
    {
        m_frogController = new FrogController();
        m_frogController.Initialize();
    }

    public void UpdateByFrame()
    {
        m_frogController.UpdateByFrame();
    }
}
