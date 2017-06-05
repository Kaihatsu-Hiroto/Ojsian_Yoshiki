using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour {

    public PowerGage m_powerGage { get; private set; }  //元のpowerGage（今後は不要）
   public PowerMater m_powerMater { get; private set; } //追加したゲージ移動動作
    Rigidbody2D rigidbody;
    Animator animator;

    //着地用変数
    bool isGrounded;

    //プレイヤー跳躍力
    public Vector3 power = new Vector3(0, 0);

    //加算減算用跳躍力
    Vector3 CHARGE_POW = new Vector3(0.5f, 0.5f);

    //切り返し用フラグ
    int chargeVec = 1;

    //最大パワー  //最小パワー&リセット
    Vector3 MAXPOWER = new Vector3(10f, 10f);
    Vector3 LOWPOWER = new Vector3(0f, 0f);

    //チャージ用フラグ
    bool CHARGE = false;


    public void Initialize()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
         m_powerGage = new PowerGage();   //不要となるpowerGage
        //m_powerMater = new PowerMater();
        m_powerGage.Initialize();         //不要となるpowerGage
        //m_powerMater.Initialize(); 
    }

    public void UpdateByFrame()
    {
        GetKeyCode();
        m_powerGage.UpdateByFrame();    //不要となるpowerGage
       // m_powerMater.UpdateByFrame();

    }


    //ジャンプ入力関係
    void GetKeyCode()
    {

        //葉っぱに接しているかを算出
        isGrounded = Physics2D.Raycast(
            transform.position, Vector2.down,
            1.6f, 1 << LayerMask.NameToLayer("Leaf"));

        if (isGrounded)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Charge();
                Debug.Log(power.x);

            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                animator.Play("FrogJump");//機能してない
                rigidbody.velocity = power;
                power = LOWPOWER;
            }
        }
        m_powerGage.UpdateByFrame(); //Gage⇒Materに書き換え
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
