using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class AnimationManager : MonoBehaviour
{
    public Sprite[] IdleSprites, WalkingSprites;
    private bool FacingRight, IsMoving;
    private SpriteRenderer SpriteRenderer;
    private float Timer;
    private int WalkingIndex = 0, IdleIndex = 0; // To know on which point of the array the animation is
    private CollisionDetection collisionDetection;

    void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
        collisionDetection = GetComponent<CollisionDetection>();
    }

    void Update()
    {
        SpriteRenderer.flipX = !FacingRight;
        if (IsMoving)
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

        IsMoving = inputVal.x != 0;

        if (inputVal.x > 0)
        {
            FacingRight = true;
        }
        if (inputVal.x < 0)
        {
            FacingRight = false;
        }

    }

    void Walking()
    {
        float TimeToChangeSprite = 0.1f;
        Timer += Time.deltaTime;
        if (Timer > TimeToChangeSprite)
        {
            WalkingIndex++;
            if (WalkingIndex >= WalkingSprites.Length)
            {
                WalkingIndex = 0;
            }
            SpriteRenderer.sprite = WalkingSprites[WalkingIndex];
            Timer = 0;
        }
    }

    void Idle()
    {
        float TimeToChangeSprite = 0.5f;
        Timer += Time.deltaTime;
        if (Timer > TimeToChangeSprite)
        {
            IdleIndex++;
            if (IdleIndex >= IdleSprites.Length)
            {
                IdleIndex = 0;
            }
            SpriteRenderer.sprite = IdleSprites[IdleIndex];
            Timer = 0;
        }
    }
}
