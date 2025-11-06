using UnityEngine;

public class Body : MonoBehaviour
{
    public GameObject bodyShape;

    void Start()
    {
    }

    public void CreateBody()
    {
        Instantiate(bodyShape, new Vector3(0f,0f,0f),
       Quaternion.identity, transform);
    }
}

