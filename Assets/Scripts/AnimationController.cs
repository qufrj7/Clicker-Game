using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class AnmationController : MonoBehaviour
{
    // 마우스를 좌클릭할 때마다 머쉬맘이 애니메이션을 실행해야 한다.
    // 1. 유니티의 컴포넌트 기능을 c#에서 사용하기 위해 호출한다.
    // 2. 애니메이션들이 클릭할 때마다 변경되도록 애니메이션 컨트롤러를 구성해주세요. 이때 transition에 걸리는 시간을 0초로 하고, 누르자마자 변경되도록 하세요.
    // 3. 애니메이션 변수가 변하도록 하세요. 0 → 1 → 2 → 0 → 1 → 2 이렇게 반복되게 하여 애니메이션이 idle → jump → attacked → idle… 이렇게 반복될 수 있게 해주세요.
    private int animationVariable = 0;
    private Animator _animator;

    // _animator 세팅 
    void Awake() // 스크립트가 활성화되었을 때 무엇을 해야 하는가
    {
        _animator = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        // animationVariable을 수정
        animationVariable = (animationVariable + 1) % 3;
        _animator.SetInteger("State", animationVariable);
    }
}
