using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [Header("Settings")]
    [Tooltip("점프파워 설정")]
    public float JumpPower;

    [Header("References")]
    public Rigidbody2D JumpRig;
    void Start()
    {
        JumpRig = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            JumpRig.AddForce(new Vector2(JumpRig.linearVelocityX, JumpRig.linearVelocityY));
        }
    }
}
