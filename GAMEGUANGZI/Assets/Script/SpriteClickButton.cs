using UnityEngine;

public class SpriteClickButton : MonoBehaviour
{
    [Header("Object To Show / Hide")]
    public GameObject targetObject;

    [Header("Click Setting")]
    public bool toggle = true;

    private void OnMouseDown()
    {
        Debug.Log(gameObject.name + " clicked");

        if (targetObject == null)
        {
            return;
        }

        if (toggle)
        {
            targetObject.SetActive(!targetObject.activeSelf);
        }
        else
        {
            targetObject.SetActive(true);
        }
    }
}