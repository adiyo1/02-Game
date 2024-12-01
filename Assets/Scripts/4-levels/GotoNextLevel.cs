using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoNextLevel : MonoBehaviour
{
    [SerializeField] string triggeringTag;
    [SerializeField] string victorySceneName;
    public NumberField numberField;

    void Start()
    {
        if (numberField == null)
        {
            numberField = Object.FindAnyObjectByType<NumberField>();
            //numberField = FindObjectOfType<NumberField>();
            if (numberField == null)
            {
                Debug.LogError("No NumberField found in the scene! Please ensure it exists.");
            }
        }
    }

    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (numberField == null)
        {
            Debug.LogError("numberField is not assigned! Please assign it in the Inspector.");
            return;
        }

        int currentNumber = numberField.GetNumber();
        if (other.CompareTag(triggeringTag))
        {
            Debug.Log("Trigger detected.");
            Debug.Log($"Current number in NumberField: {currentNumber}");

            if (currentNumber >= 5)
            {
                Debug.Log("Player reached the next level.");
                SceneManager.LoadScene(victorySceneName);
            }
            else
            {
                Debug.Log($"Not enough points to proceed. Current: {currentNumber}, Required: 5");
            }
        }
    }
}


