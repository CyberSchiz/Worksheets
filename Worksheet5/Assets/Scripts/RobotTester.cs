using UnityEngine;

public class RobotTester : MonoBehaviour
{
    public RobotBuilder robotBuilder;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            robotBuilder.BuildRobot();
        }
    }
}


