using UnityEngine;
public class Coin : Interactable
{
    public override void OnInteract()
    {
        Debug.Log("Coin Collected! Score +1");
        Destroy(gameObject); 
    }
}