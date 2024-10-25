using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class AnmationController : MonoBehaviour
{
    // ���콺�� ��Ŭ���� ������ �ӽ����� �ִϸ��̼��� �����ؾ� �Ѵ�.
    // 1. ����Ƽ�� ������Ʈ ����� c#���� ����ϱ� ���� ȣ���Ѵ�.
    // 2. �ִϸ��̼ǵ��� Ŭ���� ������ ����ǵ��� �ִϸ��̼� ��Ʈ�ѷ��� �������ּ���. �̶� transition�� �ɸ��� �ð��� 0�ʷ� �ϰ�, �����ڸ��� ����ǵ��� �ϼ���.
    // 3. �ִϸ��̼� ������ ���ϵ��� �ϼ���. 0 �� 1 �� 2 �� 0 �� 1 �� 2 �̷��� �ݺ��ǰ� �Ͽ� �ִϸ��̼��� idle �� jump �� attacked �� idle�� �̷��� �ݺ��� �� �ְ� ���ּ���.
    private int animationVariable = 0;
    private Animator _animator;

    // _animator ���� 
    void Awake() // ��ũ��Ʈ�� Ȱ��ȭ�Ǿ��� �� ������ �ؾ� �ϴ°�
    {
        _animator = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        // animationVariable�� ����
        animationVariable = (animationVariable + 1) % 3;
        _animator.SetInteger("State", animationVariable);
    }
}
