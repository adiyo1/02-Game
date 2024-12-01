//using UnityEngine;
//using TMPro; // TextMeshPro נדרש עבור 

///**
// * This component destroys its object when it triggers a 2D collider with the given tag,
// * but only after its health points reach zero.
// */
//public class DestroyOnTrigger2D : MonoBehaviour
//{
//    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
//    [SerializeField] string triggeringTag;

//    [Tooltip("Initial health points for the player")]
//    [SerializeField] int maxHealth = 3;

//    private int currentHealth;

//    [Tooltip("Text UI to display the current health points")]
//    [SerializeField] TextMeshProUGUI healthText;

//    private void Start()
//    {
//        currentHealth = maxHealth;
//        UpdateHealthUI();
//    }

//    private void OnTriggerEnter2D(Collider2D other)
//    {
//        if (other.CompareTag(triggeringTag))
//        {
//            currentHealth--;

//            UpdateHealthUI();

//            if (currentHealth <= 0)
//            {
//                Destroy(gameObject); // השמדת האובייקט (למשל השחקן)
//            }

//            Destroy(other.gameObject); // השמדת האובייקט שפגע
//        }
//    }

//    private void UpdateHealthUI()
//    {
//        if (healthText != null)
//        {
//            healthText.text = "Health: " + currentHealth.ToString();
//        }
//    }

//    public void Heal(int amount)
//    {
//        currentHealth += amount;

//        if (currentHealth > maxHealth)
//        {
//            currentHealth = maxHealth;
//        }

//        UpdateHealthUI();
//    }
//    public int GetCurrentHealth()
//    {
//        return currentHealth;
//    }

//}



using UnityEngine;
using UnityEngine.SceneManagement; // נדרש כדי לטעון סצנות

/**
 * This component destroys its object when it triggers a 2D collider with the given tag,
 * but only after its health points reach zero.
 */
public class DestroyOnTrigger2D : MonoBehaviour
{
    //[Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    //[SerializeField] string triggeringTag;

    //[Tooltip("Initial health points for the player")]
    //[SerializeField] int maxHealth = 3;

    //private int currentHealth;

    ////[Tooltip("Text UI to display the current health points")]
    ////[SerializeField] TMPro.TextMeshProUGUI healthText;

    //[Tooltip("Name of the Game Over scene")]
    //[SerializeField] string gameOverSceneName = "level-game-over"; // שם סצנת GAME OVER

    //private void Start()
    //{
    //    currentHealth = maxHealth;
    //    UpdateHealthUI();
    //}

    ////private void OnTriggerEnter2D(Collider2D other)
    ////{
    ////    if (other.CompareTag(triggeringTag))
    ////    {
    ////        //GameObject.FindGameObjectWithTag("Player").SetCurrentHealth(currentHealth--);
    ////        currentHealth--;

    ////        UpdateHealthUI();

    ////        // בדיקה אם הבריאות של השחקן שווה ל-0
    ////        if (currentHealth <= 0)
    ////        {
    ////            Debug.Log("Player health is 0. Loading Game Over scene...");
    ////            Destroy(gameObject);
    ////            SceneManager.LoadScene(gameOverSceneName); // טעינת סצנת GAME OVER
    ////        }

    ////        Destroy(other.gameObject); // השמדת האובייקט שפגע
    ////    }
    ////}

    //private void UpdateHealthUI()
    //{
    //    //if (healthText != null)
    //    //{
    //    //    healthText.text = "Health: " + currentHealth.ToString();
    //    //}
    //}

    //public int GetCurrentHealth()
    //{
    //    return currentHealth; // החזרת הבריאות הנוכחית
    //}

    ////public void Heal(int amount)
    ////{
    ////    currentHealth += amount;

    ////    if (currentHealth > maxHealth)
    ////    {
    ////        currentHealth = maxHealth;
    ////    }

    ////    UpdateHealthUI();
    ////}
    //void Update()
    //{
    //    if (SingletonByName.Instance.GetCurrentHealth() <= 0)
    //    {
    //        Debug.Log("Health is 0. Loading Game Over scene...");
    //        SceneManager.LoadScene(gameOverSceneName);
    //    }
    //}
}


