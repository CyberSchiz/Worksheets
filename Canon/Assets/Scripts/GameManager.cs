using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject CannonBall;
    public GameObject Canon;
    Vector3 CannonPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CannonPos = Canon.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        MouseClicks();
    }

    void MouseClicks()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Pressed left-click.");
            Instantiate(Bullet, CannonPos, Canon.transform.rotation);
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Pressed right-click.");
            Instantiate(CannonBall, CannonPos, Canon.transform.rotation);

        }
    }
}
