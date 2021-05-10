using UnityEngine;

public class GameHandler : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        HealthSystem healthSystem = new HealthSystem(100);

        Debug.Log("Health is: " + healthSystem.GetHealthPercent());
        healthSystem.Damage(10);
        Debug.Log("Health is: " + healthSystem.GetHealthPercent());
        // healthSystem.Heal(10);
       // Debug.Log("Health is: " + healthSystem.GetHealth());
    }

  
}
