using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogController : MonoBehaviour {

    public Frog m_frog { get; private set; }

    public void Initialize()
    {
        m_frog = Instantiate(Resources.Load<GameObject>("Prehub/Frog"),//ファイルパス指定でプレハブを直接開いてる
            FrogManager.Instance.transform).GetComponent<Frog>();
        m_frog.transform.position = new Vector3(-3.5f, 0, 0);

        m_frog.Initialize();

    }

    public void UpdateByFrame()
    {

        m_frog.UpdateByFrame();

    }


}
