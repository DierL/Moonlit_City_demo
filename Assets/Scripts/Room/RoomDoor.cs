
using UnityEngine;

public class RoomDoor : MonoBehaviour
{
    [SerializeField]
    private Collider2D doorCollider;

    [SerializeField]
    private SpriteRenderer doorSprite;

    public void Open()
    {
        doorCollider.enabled = false;
        doorSprite.enabled = false;

        Debug.Log($"{name}: Door Open!");
    }

    public void Close()
    {
        doorCollider.enabled = true;
        doorSprite.enabled = true;

        Debug.Log($"{name}: Door Closed!");
    }
}
