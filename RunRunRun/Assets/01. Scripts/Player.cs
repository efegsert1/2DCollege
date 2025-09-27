using Unity.VisualScripting;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [Header("Settings")]
    [Tooltip("점프파워 설정")]
    public float JumpPower;

    [Header("References")]
    public Rigidbody2D JumpRig;

    public Animator Playeranim;

    public SpriteRenderer sr;
    private bool isGround = true; 
    void Start()
    {
        JumpRig = GetComponent<Rigidbody2D>();
        Playeranim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            JumpRig.AddForce(Vector2.up * JumpPower, ForceMode2D.Impulse);
            isGround = false;
            Playeranim.SetBool("isJump", true);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            if (!isGround)
            {
                Playeranim.SetBool("isJump", false);
            }
            isGround = true;
        }
    }
}
