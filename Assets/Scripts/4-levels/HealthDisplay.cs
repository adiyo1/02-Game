
using UnityEngine;
using TMPro;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI healthText; // השדה שמציג את הבריאות

    void Update()
    {
        // בדיקה אם הסינגלטון קיים
        if (SingletonByName.Instance != null && healthText != null)
        {
            // עדכון הבריאות בטקסט
            healthText.text = "Health: " + SingletonByName.Instance.GetCurrentHealth();
        }
    }
}
