using UnityEngine;

public class Arm : MonoBehaviour
{
    public GameObject armShape;
    public void CreateArm()
    {
        Instantiate(armShape, new Vector3(0.5f,0f,0f),
       Quaternion.identity, transform);
    }
}

