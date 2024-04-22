using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GroundChecker : MonoBehaviour
{
    //�ڒn�����ꍇ�̏���
    public UnityEvent OnEnterGround;
    //�n�ʂ��痣�ꂽ�ꍇ�̏���
    public UnityEvent OnExitGround;
    //�ڒn��
    private int enterNum = 0;

    private void OnTriggerStay(Collider collision)
    {
        Debug.Log("OnGround!");
        enterNum++;
        OnEnterGround.Invoke();
    }

    private void OnTriggerExit(Collider collision)
    {
        Debug.Log("ExitGround!");
        enterNum--;
        if (enterNum <= 0)
        {
            OnExitGround.Invoke();
        }
    }
}