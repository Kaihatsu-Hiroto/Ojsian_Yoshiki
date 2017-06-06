using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    /// <summary>
    /// Singleton
    /// </summary>
    private static GameManager m_instance;

    public static GameManager Instance
    { //GMを探す
        get
        {
            if (m_instance == null)
            {
                m_instance = FindObjectOfType<GameManager>();
            }
            return m_instance;
        }
    }

    public FrogManager m_frogManager { get; private set; }

    public FallController m_fallController { get; private set; }
    
    private CameraController m_cameraController;

    void Start()
    {
        //TODO:処理の分割

       // m_timer = new GameTimer();
       // m_timer.Initialize();

        m_frogManager = FrogManager.Instance;
        m_frogManager.Initialize();  //初期化

        m_fallController = new FallController();
        m_fallController.Initialize();  //初期化

        //m_monsterManager = MonsterManager.Instance;
        // m_monsterManager.Initialize();  //初期化

        m_cameraController = FindObjectOfType<CameraController>();
        m_cameraController.Initialize();


        //m_textManager = new TextManager();
        //m_textManager.Initialize();
    }

    void Update()
    {

        //m_textManager.UpdateByFrame();
        m_cameraController.UpdateByFrame();
        // m_monsterManager.UpdateByFrame();
        m_frogManager.UpdateByFrame();
        m_fallController.UpdateByFrame();
    }
}
