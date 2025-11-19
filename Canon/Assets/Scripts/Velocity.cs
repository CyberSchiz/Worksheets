using UnityEngine;

public class Velocity : MonoBehaviour
{
    public float moveSpeed = 7.0f;

    public virtual void Move()
    {
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

    }
    private void Update()
    {
        Move();
    }
}