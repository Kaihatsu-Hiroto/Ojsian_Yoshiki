using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour {

    public PowerGage m_powerGage { get; private set; }

    Rigidbody2D rigidbody;
    Animator animator;

    //着地用変数
    bool isGroundedL;
    bool isGroundedR;

    //プレイヤー跳躍力
    public Vector3 power = new Vector3(0, 0);

    //加算減算用跳躍力
    Vector3 CHARGE_POW = new Vector3(0.5f, 0.5f);

    //切り返し用フラグ
    int chargeVec = 1;

    //最大パワー  //最小パワー&リセット
    Vector3 MAXPOWER = new Vector3(10f, 10f);
    Vector3 LOWPOWER = new Vector3(0f, 0f);

    public void Initialize()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        m_powerGage = new PowerGage();
        m_powerGage.Initialize(); 
    }

    public void UpdateByFrame()
    {
        GetKeyCode();
        m_powerGage.UpdateByFrame();

    }


    //ジャンプ入力関係
    void GetKeyCode()
    {
        //葉っぱに接しているかを算出//左端
        isGroundedL = Physics2D.Raycast(
            transform.position += new Vector3(-2.3f, 0) , Vector2.down,
            0.8f, 1 << LayerMask.NameToLayer("Leaf"));

        //葉っぱに接しているかを算出//右端
        isGroundedR = Physics2D.Raycast(
            transform.position += new Vector3(2.3f, 0), Vector2.down,
            0.8f, 1 << LayerMask.NameToLayer("Leaf"));


        if (isGroundedL || isGroundedR)
        {
            rigidbody.velocity = LOWPOWER;
            if (Input.GetKey(KeyCode.Space))
            {
                Charge();

            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                animator.Play("FrogJump");
                rigidbody.velocity = power;
                power = LOWPOWER;
            }
        }
        m_powerGage.UpdateByFrame();
    }

    //ジャンプ力チャージ
    void Charge()
    {
        if(chargeVec == 1)
            High();
        if (chargeVec == -1)
            Low();
    }

    //チャージ上昇時
    void High()
    {
        power += CHARGE_POW;
        if (power.x > MAXPOWER.x)
            chargeVec = -1;
    }

    //チャージ減少時
    void Low()
    {
        power -= CHARGE_POW;
        if (power.x < LOWPOWER.x)
            chargeVec = 1;
    }
}
