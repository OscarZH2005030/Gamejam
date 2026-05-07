using UnityEngine;

public class InventoryToggle : MonoBehaviour
{
    [Header("Backpack UI")]
    public GameObject backpackUI;

    [Header("Mouse Settings")]
    public bool showMouseWhenOpen = true;

    private bool isOpen = false;

    private void Start()
    {
        if (backpackUI != null)
        {
            backpackUI.SetActive(false);
        }

        isOpen = false;

        if (showMouseWhenOpen)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            ToggleBackpack();
        }
    }

    private void ToggleBackpack()
    {
        isOpen = !isOpen;

        if (backpackUI != null)
        {
            backpackUI.SetActive(isOpen);
        }

        if (showMouseWhenOpen)
        {
            Cursor.visible = isOpen;

            if (isOpen)
            {
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }
}