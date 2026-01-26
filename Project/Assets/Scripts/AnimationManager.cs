using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class AnimationManager : MonoBehaviour
{
    public Sprite[] IdleSprites, WalkingSprites;
    private bool facingRight, isMoving;
    private SpriteRenderer spriteRenderer;
    private float timer;
    private int walkingIndex = 0, idleIndex = 0; // To know on which point of the array the animation is
    private CollisionDetection collisionDetection;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        collisionDetection = GetComponent<CollisionDetection>();
    }

    void Update()
    {
        spriteRenderer.flipX = !facingRight;
        if (isMoving)
        {
            Walking();
        }

        else if (collisionDetection.IsGrounded)
        {
            Idle();
        }
    }

    void OnMove(InputValue value)
    {

        var inputVal = value.Get<Vector2>();

        isMoving = inputVal.x != 0;

        if (inputVal.x > 0)
        {
            facingRight = true;
        }
        if (inputVal.x < 0)
        {
            facingRight = false;
        }

    }

    void Walking()
    {
        float timeToChangeSprite = 0.1f;
        timer += Time.deltaTime;
        if (timer > timeToChangeSprite)
        {
            walkingIndex++;
            if (walkingIndex >= WalkingSprites.Length)
            {
                walkingIndex = 0;
            }
            spriteRenderer.sprite = WalkingSprites[walkingIndex];
            timer = 0;
        }
    }

    void Idle()
    {
        float timeToChangeSprite = 0.5f;
        timer += Time.deltaTime;
        if (timer > timeToChangeSprite)
        {
            idleIndex++;
            if (idleIndex >= IdleSprites.Length)
            {
                idleIndex = 0;
            }
            spriteRenderer.sprite = IdleSprites[idleIndex];
            timer = 0;
        }
    }
}
