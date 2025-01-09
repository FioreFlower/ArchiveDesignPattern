using System.Collections;
using UnityEngine;

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
