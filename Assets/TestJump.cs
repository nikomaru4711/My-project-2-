using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestJump : MonoBehaviour
{
    public Rigidbody2D rb;
    public float JumpPower;
    public bool OnGround { get; set; }//�ǋL
    int i = 99;

    private void Start()
    {
        OnGround = false;
    }

    //Rigitbody�������邽��FixedUpdate�ŏ������s��
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
        
        //�ڒn���Ă���΃W�����v�ł���
        if (Input.GetButtonDown("Jump") && OnGround)//�ǋL
        {
            rb.velocity = transform.up * JumpPower;
            //�W�����v�����u�Ԑڒn���������
            OnGround = false;//�ǋL
        }
    }
}
