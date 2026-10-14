using UnityEngine;

public class ControlFisicas : MonoBehaviour
{
    private void Start()
    {
        Physics.simulationMode = SimulationMode.Script;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Physics.Simulate(Time.fixedDeltaTime);
        }
    }
}