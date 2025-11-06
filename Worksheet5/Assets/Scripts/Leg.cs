using UnityEngine;

public class Leg : MonoBehaviour
{
    public GameObject legShape;
    public void CreateLeg()
    {
        Instantiate(legShape, new Vector3(0f,-0.5f,0f),
       Quaternion.identity, transform);
    }
}

