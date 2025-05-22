using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float Health { get; private set; } = 1f;

    private bool isFalling = false;
    private float fallStartTime;

    private void Update()
    {
        if (!IsGrounded())
        {
            if (!isFalling)
            {
                isFalling = true;
                fallStartTime = Time.time;
            }
        }
        else if (isFalling)
        {
            isFalling = false;
            float fallDuration = Time.time - fallStartTime;

            if (fallDuration > 0.2f)
            {
                TakeDamage(0.1f); // 10%
            }
        }
    }

    private bool IsGrounded()
    {
        return Physics.Raycast(transform.position + Vector3.up * 0.1f, Vector3.down, 0.2f);
    }

    private void TakeDamage(float amount)
    {
        Health = Mathf.Max(0f, Health - amount);
    }
}
