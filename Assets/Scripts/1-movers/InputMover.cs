using UnityEngine;
using UnityEngine.InputSystem;

/**
 * This component moves the player object when the player presses arrow keys
 * and detects collisions to interact with health management.
 */
public class InputMover : MonoBehaviour
{
    [Tooltip("Speed of movement, in meters per second")]
    [SerializeField] float speed = 10f;

    [SerializeField]
    InputAction move = new InputAction(
        type: InputActionType.Value, expectedControlType: nameof(Vector2));

    private int playerHealth = 0;

    void OnEnable()
    {
        move.Enable();
    }

    void OnDisable()
    {
        move.Disable();
    }

    void Start()
    {
        // חיפוש רכיב הבריאות המחובר לאובייקט
        playerHealth = SingletonByName.Instance.GetCurrentHealth();
        
    }

    void Update()
    {
        // תנועה של השחקן
        Vector2 moveDirection = move.ReadValue<Vector2>();
        Vector3 movementVector = new Vector3(moveDirection.x, moveDirection.y, 0) * speed * Time.deltaTime;
        transform.position += movementVector;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("HealthPickup")) // אם זה נקודת בריאות
        {
            Destroy(other.gameObject); // הסרת האובייקט מהמשחק
        }
    }
}
