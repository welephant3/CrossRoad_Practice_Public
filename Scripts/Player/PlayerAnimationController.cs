using UnityEngine;

public class PlayerAnimationController : AnimationController
{
    private static readonly int IsWalk = Animator.StringToHash("IsWalk");
    private static readonly int IsEat = Animator.StringToHash("IsEat");
    
    private readonly float magnituteThreshold = 0.5f;

    protected override void Awake()
    {
        base.Awake();
    }

    void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector3 obj)
    {
        animator.SetBool(IsWalk, obj.magnitude > magnituteThreshold);
    }

    //private void Eat()
    //{
    //    animator.SetTrigger(IsEat);
    //}
}
