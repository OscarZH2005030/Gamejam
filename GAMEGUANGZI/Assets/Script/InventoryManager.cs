using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;

    [Header("Backpack Item Icons")]
    public GameObject itemCIcon;
    public GameObject itemHIcon;
    public GameObject itemOIcon;
    public GameObject itemTabletIcon;
    public GameObject itemAlcoholLampIcon;
    public GameObject itemKeyIcon;

    private bool hasC = false;
    private bool hasH = false;
    private bool hasO = false;
    private bool hasTablet = false;
    private bool hasAlcoholLamp = false;
    private bool hasKey = false;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UpdateBackpackUI();
    }

    public void CollectItem(int itemID)
    {
        if (itemID == 1)
        {
            hasC = true;
        }
        else if (itemID == 2)
        {
            hasH = true;
        }
        else if (itemID == 3)
        {
            hasO = true;
        }
        else if (itemID == 4)
        {
            hasTablet = true;
        }
        else if (itemID == 5)
        {
            hasAlcoholLamp = true;
        }
        else if (itemID == 6)
        {
            hasKey = true;
        }

        UpdateBackpackUI();
    }

    private void UpdateBackpackUI()
    {
        if (itemCIcon != null)
        {
            itemCIcon.SetActive(hasC);
        }

        if (itemHIcon != null)
        {
            itemHIcon.SetActive(hasH);
        }

        if (itemOIcon != null)
        {
            itemOIcon.SetActive(hasO);
        }

        if (itemTabletIcon != null)
        {
            itemTabletIcon.SetActive(hasTablet);
        }

        if (itemAlcoholLampIcon != null)
        {
            itemAlcoholLampIcon.SetActive(hasAlcoholLamp);
        }

        if (itemKeyIcon != null)
        {
            itemKeyIcon.SetActive(hasKey);
        }
    }
}