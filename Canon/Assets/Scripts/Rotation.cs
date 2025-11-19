using UnityEngine;

public class Rotation : MonoBehaviour
{
    Quaternion clampRotationLow, clampRotationHigh;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        clampRotationLow = Quaternion.Euler(0, 0, -65f);
        clampRotationHigh = Quaternion.Euler(0, 0, 65f);
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
        CannonRotation.z = Mathf.Clamp(CannonRotation.z, clampRotationLow.z, clampRotationHigh.z);
        CannonRotation.w = Mathf.Clamp(CannonRotation.w, clampRotationLow.w, clampRotationHigh.w);
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, CannonRotation, Time.deltaTime * 5f);
        
    }
}
