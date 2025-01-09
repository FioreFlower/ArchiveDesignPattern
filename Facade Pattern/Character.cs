using System.Collections;
using UnityEngine;

// 첫 번째 객체: 점프 동작과 디버그 로그 출력.
// 두 번째 객체: 달리기 동작과 디버그 로그 출력.
// 세 번째 객체: 점프한 후 3초 후에 달리기 동작과 디버그 로그 출력.

// 공통된 동작을 수행하는 기반 클래스
public class Character : MonoBehaviour
{ 
    protected Animator animator;
    protected Rigidbody rigidbody;
    protected TextMesh textMesh;
    
    protected float JumpForce = 3;
    protected virtual void Awake()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
        textMesh = GetComponentInChildren<TextMesh>();
    }

    protected void PlayRunAnimation()
    {
        animator.SetFloat("Speed", 1f);
    }

    protected void PlayJumpAnimation()
    {
        animator.CrossFade("Jump", 0.1f);
        rigidbody.velocity = new Vector3(rigidbody.velocity.x, JumpForce, rigidbody.velocity.z);
    }

    protected void DelayForSecond(float seconds)
    {
        StartCoroutine(C_DelayForSecond(seconds));
    }
    private IEnumerator C_DelayForSecond(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        animator.CrossFade("Idles", 0.1f);
    }
    
    public virtual void Doing() { }
}