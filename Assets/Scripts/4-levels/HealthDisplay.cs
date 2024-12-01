
using UnityEngine;
using TMPro;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI healthText; // ���� ����� �� �������

    void Update()
    {
        // ����� �� ��������� ����
        if (SingletonByName.Instance != null && healthText != null)
        {
            // ����� ������� �����
            healthText.text = "Health: " + SingletonByName.Instance.GetCurrentHealth();
        }
    }
}
