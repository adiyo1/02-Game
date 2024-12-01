
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * Implements a singleton pattern in Unity:
 * Makes sure that there is exactly one GameObject with the same name of the current one.
 * Manages player health and score across scenes.
 */
public class SingletonByName : MonoBehaviour
{
    public static SingletonByName Instance; // Reference to the singleton instance

    [Tooltip("Current health points of the player")]
    public int currentHealth = 3; // החיים הנוכחיים
    [Tooltip("Maximum health points of the player")]
    public int maxHealth = 3; // הבריאות המקסימלית

    //[Tooltip("Current score of the player (resets each level)")]
    //public int currentScore = 0; // ניקוד נוכחי שמתאפס בכל שלב

    [Tooltip("Text UI to display the current health points")]
    [SerializeField] TMPro.TextMeshProUGUI healthText;

    //[SerializeField] string loseSceneName;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }


        UpdateHealthUI();
        string myName = gameObject.name;      
    }

    // פונקציות לניהול הבריאות
    public void SetCurrentHealth(int health)
    {
        currentHealth+=health;
        healthText.text = "Health: " + currentHealth.ToString();
        Debug.Log("Health set to: " + currentHealth);
    }


    private void UpdateHealthUI()
    {
        if (healthText != null)
        {
            healthText.text = "Health: " + currentHealth.ToString();
        }
    }

    public int GetCurrentHealth()
    {
        return currentHealth;
    }

    //// פונקציות לניהול ניקוד
    //public void AddScore(int points)
    //{
    //    currentScore += points;
    //    Debug.Log("Score added. Current score: " + currentScore);
    //}

    //public void ResetScore()
    //{
    //    currentScore = 0;
    //    Debug.Log("Score reset.");
    //}

    //public int GetScore()
    //{
    //    return currentScore;
    //}

    public void Heal(int amount)
    {
        currentHealth += amount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        UpdateHealthUI();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (gameObject.CompareTag("Player") && other.CompareTag("Enemy"))
        {
            currentHealth--;
            Debug.Log($"numOfLiveis: "+currentHealth);
            UpdateHealthUI();
            // בדיקה אם הבריאות של השחקן שווה ל-0
            if (currentHealth <= 0)
            {
                Debug.Log("Player health is 0. Loading Game Over scene...");
                Destroy(gameObject);
                SceneManager.LoadScene("level-game-over"); // טעינת סצנת GAME OVER
            }
            Destroy(other.gameObject); // השמדת האובייקט שפגע
        }


        if (gameObject.CompareTag("Laser") && other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject); // השמדת האויב
            Destroy(gameObject); // השמדת הלייזר
        }


        if (other.gameObject.CompareTag("HealthPickup")) // אם זה נקודת בריאות
        {
            if (currentHealth < 3)
            {
                currentHealth++;
                UpdateHealthUI();
            }
            
        }
    }
}
