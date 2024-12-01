using UnityEngine;

/**
 * This script handles the behavior of a health pickup when the player collects it.
 */
public class HealthPickup : MonoBehaviour
{
    [Tooltip("Amount of health restored when collected")]
    public int healthAmount = 1;



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //DestroyOnTrigger2D playerHealth=SingletonByName.Instance.GetCurrentHealth();
            //DestroyOnTrigger2D playerHealth = other.GetComponent<DestroyOnTrigger2D>();
            //if (playerHealth > 0)
            //{
            Debug.LogWarning("num of lives: " + SingletonByName.Instance.GetCurrentHealth());
            if (SingletonByName.Instance.GetCurrentHealth() < 3)
            {
                SingletonByName.Instance.SetCurrentHealth(1);
            }
            
            //SingletonByName.Instance.SetCurrentHealth(SingletonByName.Instance.GetCurrentHealth()+ healthAmount);
                //playerHealth.Heal(healthAmount); // הוספת הבריאות לשחקן
             Destroy(gameObject); // השמדת נקודת הבריאות
            //}
        }
    }
}


