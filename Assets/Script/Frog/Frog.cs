﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour {

    public PowerGage m_powerGage { get; private set; }

    Rigidbody2D rigidbody;//上昇
    Animator animator;

    public Vector3 power = new Vector3(0, 0);//跳躍力
    Vector3 chargePow = new Vector3(0.5f, 0.5f);

    int chargeVec = 1;
    Vector3 MAXPOWER = new Vector3(10f, 10f);//最大パワー
    Vector3 LOWPOWER = new Vector3(0f, 0f);//最小パワー&リセット
    bool CHARGE = false;


    public void Initialize()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        m_powerGage = new PowerGage();
        m_powerGage.Initialize();  //初期化
    }

    public void UpdateByFrame()
    {

        if(Input.GetKey(KeyCode.Space))
        {
            Charge();
            Debug.Log(power.x);

        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.Play("FrogJump");//機能してない
            rigidbody.velocity = power;
            power = LOWPOWER;
        }
        else
        {
            animator.Play("FrogIdle");
        }
        m_powerGage.UpdateByFrame();

    }

    void Charge()
    {
        if(chargeVec == 1)
            High();
        if (chargeVec == -1)
            Low();
    }

    void High()
    {
        power += chargePow;
        if (power.x > MAXPOWER.x)
            chargeVec = -1;
    }
    void Low()
    {
        power -= chargePow;
        if (power.x < LOWPOWER.x)
            chargeVec = 1;
    }
}
