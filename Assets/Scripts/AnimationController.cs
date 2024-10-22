using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // 마우스를 좌클릭할 때마다 머쉬맘이 애니메이션을 실행해야 한다.
    private int animationVariable = 0;
    private Animator _animator;

    // _animator 세팅 
    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        // animationVariable을 수정
        _animator.SetInt("State", animationVariable);
    }
}
