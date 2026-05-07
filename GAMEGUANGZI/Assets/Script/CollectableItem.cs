using UnityEngine;

public class CollectableItem : MonoBehaviour
{
    [Header("Item ID")]
    public int itemID = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (InventoryManager.Instance != null)
            {
                InventoryManager.Instance.CollectItem(itemID);
            }

            Destroy(gameObject);
        }
    }
}