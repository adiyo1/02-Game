//using UnityEngine;
//using TMPro; // �� �� ������ �-TextMeshPro

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
//        // ����� ������ �������
//        currentHealth = maxHealth;
//        UpdateHealthUI();
//    }

//    public void Heal(int amount)
//    {
//        //currentHealth += amount;

//        if (currentHealth > maxHealth)
//        {
//            //currentHealth = maxHealth; // ������� �� ����� ����� ��� ������� ���������
//        }

//        //UpdateHealthUI(); // ����� ������ �� �������
//    }


//    public void TakeDamage(int damage)
//    {
//        //currentHealth -= damage; // ����� �������

//        if (currentHealth <= 0)
//        {
//            //currentHealth = 0; // �� ���� ���� ���� �-0
//            Debug.Log("Player is out of health!");
//        }

//        //UpdateHealthUI(); // ����� ������ �� �������
//    }

//    private void UpdateHealthUI()
//    {
//        if (healthText != null)
//        {
//            healthText.text = "Health: " + currentHealth.ToString();
//        }
//    }
//}



