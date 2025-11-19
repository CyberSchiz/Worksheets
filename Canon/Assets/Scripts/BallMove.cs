using UnityEngine;

public class BallMove : Velocity
{
    Vector3 velocity;

    public override void Move()
    {
        float gravity = -4f;
        base.Move();
        velocity.y += gravity * Time.deltaTime;

        transform.position +=  velocity * Time.deltaTime;

    }


}
