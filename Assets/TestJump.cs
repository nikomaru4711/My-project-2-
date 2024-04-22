using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestJump : MonoBehaviour
{
    public Rigidbody2D rb;
    public float JumpPower;
    public bool OnGround { get; set; }//追記
    int i = 99;

    private void Start()
    {
        OnGround = false;
    }

    //RigitbodyをいじるためFixedUpdateで処理を行う
    private void Update()
    {
        i++;
        if(i == 100)
        {
            if(OnGround== true)
            {
                Debug.Log("true");
            } else
            {
                Debug.Log("false");
            }
            i = 0;
        }

        if(Input.GetButtonDown("Jump"))
        {
            Debug.Log("Jump");
        }
        
        //接地していればジャンプできる
        if (Input.GetButtonDown("Jump") && OnGround)//追記
        {
            rb.velocity = transform.up * JumpPower;
            //ジャンプした瞬間接地判定を解除
            OnGround = false;//追記
        }
    }
}
