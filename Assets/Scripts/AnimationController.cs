using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // ���콺�� ��Ŭ���� ������ �ӽ����� �ִϸ��̼��� �����ؾ� �Ѵ�.
    private int animationVariable = 0;
    private Animator _animator;

    // _animator ���� 
    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        // animationVariable�� ����
        _animator.SetInt("State", animationVariable);
    }
}
