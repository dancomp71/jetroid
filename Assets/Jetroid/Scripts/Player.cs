using UnityEngine;
using System.Collections;
using Assets.Jetroid.Scripts;

public class Player : MonoBehaviour
{
    private PlayerController controller;
    private Animator animator;

    // player movement

    public float speed = 150f;
    public Vector2 maxVelocity = new Vector2(60, 100);

    private Rigidbody2D body2D;
    private SpriteRenderer renderer2D;

    // player flying

    public float jetSpeed = 200f;
    public bool standing;
    public float standingThreshold = 4f;
    public float airSpeedMultiplier = .3f;



    // Use this for initialization
    void Start()
    {
        body2D = GetComponent<Rigidbody2D>();
        renderer2D = GetComponent<SpriteRenderer>();
        controller = GetComponent<PlayerController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var absVelocityX = Mathf.Abs(body2D.velocity.x);
        var absVelocityY = Mathf.Abs(body2D.velocity.y);

        if (absVelocityY <= standingThreshold)
        {
            standing = true;
        }
        else
        {
            standing = false;
        }

        var forceX = 0f;
        var forceY = 0f;

        if (controller.moving.x != 0)
        {
            if (absVelocityX < maxVelocity.x)
            {
                var newSpeed = speed * controller.moving.x;
                forceX = standing ? newSpeed : (newSpeed * airSpeedMultiplier);
                renderer2D.flipX = forceX < 0;
            }
            animator.SetAnimationState(PlayerAnimationStates.Running);
        }
        else
        {
            animator.SetAnimationState(PlayerAnimationStates.Idle);
        }

        if (controller.moving.y > 0)
        {
            if (absVelocityY < maxVelocity.y)
            {
                forceY = jetSpeed * controller.moving.y;
            }
            animator.SetAnimationState(PlayerAnimationStates.Flying);
        }
        else if (absVelocityY > 0 && !standing)
        {
            animator.SetAnimationState(PlayerAnimationStates.Empty);
        }

        body2D.AddForce(new Vector2(forceX, forceY));
    }
}
