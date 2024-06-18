using UnityEngine;

public class AnimationController : MonoBehaviour
{
    protected Animator animator;
    protected MainController controller;

    protected virtual void Awake()
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<MainController>();
    }
}
