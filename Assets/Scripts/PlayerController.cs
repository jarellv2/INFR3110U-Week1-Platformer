using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool isAlive = true;
    public bool IsAlive
    {
        get { return isAlive; }
        private set { isAlive = value; }
    }

    void Update()
    {
        if (!IsAlive) return;

        // Player Input & States
        if (UnityEngine.InputSystem.Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Debug.Log("Player State: Jumping");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Interactable interactable = other.GetComponent<Interactable>();
        if (interactable != null)
        {
            interactable.OnInteract();
        }

        if (other.gameObject.name == "Hazard") 
        {
            IsAlive = false;
            Debug.Log("Player Died. Losing Condition Met!");
        }
        else if (other.gameObject.name == "Goal")
        {
            Debug.Log("Level Complete! Winning Condition Met!");
        }
    }
}