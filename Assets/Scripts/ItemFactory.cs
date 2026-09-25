using UnityEngine;

public class ItemFactory : MonoBehaviour
{
    public GameObject coinPrefab;

    public GameObject CreateItem(string itemType, Vector3 position)
    {
        if (itemType == "Coin")
        {
            return Instantiate(coinPrefab, position, Quaternion.identity);
        }

        Debug.LogWarning("Item type " + itemType + " not found!");
        return null;
    }

    private void Start()
    {
        CreateItem("Coin", new Vector3(0, 3, 0));
    }
}