using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public void Initialize()
    {

    }

    public void UpdateByFrame()
    {
        //TODO:処理の可読性を上げる。関数化

        Vector3 frogPos = FrogManager.Instance.
            m_frogController.m_frog.transform.position;

        if (frogPos.x < 0)
        transform.position = new Vector3(frogPos.x + 5, 0, -10);

        if (frogPos.x > 0)
        {
            transform.position = new Vector3(frogPos.x + 5, 0, -10);
        }

    }
}
