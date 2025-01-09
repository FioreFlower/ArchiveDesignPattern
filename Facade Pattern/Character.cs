using System.Collections;
using UnityEngine;

public class Character : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rb;
    protected TextMesh TextMesh;

    private const float JumpForce = 3;
    protected virtual void Awake()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        TextMesh = GetComponentInChildren<TextMesh>();
    }

    protected void PlayRunAnimation()
    {
        animator.SetFloat("Speed", 1f);
    }

    protected void PlayJumpAnimation()
    {
        animator.CrossFade("Jump", 0.1f);
        rb.velocity = new Vector3(rb.velocity.x, JumpForce, rb.velocity.z);
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
