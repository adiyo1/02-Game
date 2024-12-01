//using UnityEngine;
//using TMPro; // אם את משתמשת ב-TextMeshPro

///**
// * This script manages the player's health points.
// */
//public class PlayerHealth : MonoBehaviour
//{
//    [Tooltip("Maximum health points for the player")]
//    [SerializeField] int maxHealth = 3;

//    private int currentHealth;

//    [Tooltip("UI Text to display current health")]
//    [SerializeField] TextMeshProUGUI healthText;

//    private void Start()
//    {
//        // אתחול נקודות הבריאות
//        currentHealth = maxHealth;
//        UpdateHealthUI();
//    }

//    public void Heal(int amount)
//    {
//        //currentHealth += amount;

//        if (currentHealth > maxHealth)
//        {
//            //currentHealth = maxHealth; // הבריאות לא יכולה לעלות מעל הבריאות המקסימלית
//        }

//        //UpdateHealthUI(); // עדכון התצוגה של הבריאות
//    }


//    public void TakeDamage(int damage)
//    {
//        //currentHealth -= damage; // הפחתת הבריאות

//        if (currentHealth <= 0)
//        {
//            //currentHealth = 0; // אי אפשר לרדת מתחת ל-0
//            Debug.Log("Player is out of health!");
//        }

//        //UpdateHealthUI(); // עדכון התצוגה של הבריאות
//    }

//    private void UpdateHealthUI()
//    {
//        if (healthText != null)
//        {
//            healthText.text = "Health: " + currentHealth.ToString();
//        }
//    }
//}



