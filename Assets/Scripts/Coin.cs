using UnityEngine;
public class Coin : Interactable
{
    public override void OnInteract()
    {
        GameManager.Instance.AddScore(1);
        Destroy(gameObject); 
    }
}