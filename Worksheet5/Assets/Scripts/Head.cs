using UnityEngine;

public class Head : MonoBehaviour
{
    public GameObject headShape;
    public void CreateHead()
    {
        Instantiate(headShape, new Vector3(0f,0.75f,0f),
       Quaternion.identity, transform);
    }
}

