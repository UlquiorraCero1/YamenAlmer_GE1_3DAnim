using UnityEngine;
using UnityEngine.InputSystem;

public class NinjaAnimationController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Keyboard.current.hKey.wasPressedThisFrame)
        {
            TriggerHappy();
        }

        if (Keyboard.current.cKey.wasPressedThisFrame)
        {
            TriggerCrazy();
        }

        if (Keyboard.current.iKey.wasPressedThisFrame)
        {
            TriggerIdle();
        }
    }

    public void TriggerHappy()
    {
        animator.SetTrigger("Happy");
    }

    public void TriggerCrazy()
    {
        animator.SetTrigger("Crazy");
    }

    public void TriggerIdle()
    {
        animator.SetTrigger("Ideal");
    }
}