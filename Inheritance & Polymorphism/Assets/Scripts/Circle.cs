using UnityEngine;
public class Circle : Shape
{
    public float rotationSpeed = 50.0f;
    public override void Move()
    {
        base.Move();
        transform.Rotate(Vector3.forward * rotationSpeed *
       Time.deltaTime);
    }
}
