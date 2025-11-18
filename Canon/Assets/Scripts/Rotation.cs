using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //int speed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        RotateCanonn();
    }


    void RotateCanonn()
    {
        Vector3 MousePos = this.transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Quaternion CannonRotation = Quaternion.LookRotation( MousePos, Vector3.forward);
        CannonRotation.x = 0;
        CannonRotation.y = 0;
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, CannonRotation, Time.deltaTime * 5f);
        
    }
}
