using UnityEngine;

public class Room : MonoBehaviour
{
    [SerializeField]
    private Transform enemiesParent;

    [SerializeField]
    private RoomDoor[] doors;

    private bool isCleared = false;

    private void Start()
    {
        if (enemiesParent == null)
        {
            Debug.LogError("Room: Enemies Parent is not assigned!");
            return;
        }

        Debug.Log($"Room Enemy Count: {enemiesParent.childCount}");

        CloseDoors();
    }

    private void Update()
    {
        CheckRoomClear();
    }

    private void CheckRoomClear()
    {
        if (isCleared) return;
        if (enemiesParent == null) return;

        if (enemiesParent.childCount == 0)
        {
            isCleared = true;

            Debug.Log("Room Clear!");

            OpenDoors();
        }
    }

    private void CloseDoors()
    {
        foreach (RoomDoor door in doors)
        {
            if (door != null)
            {
                door.Close();
            }
        }
    }

    private void OpenDoors()
    {
        foreach (RoomDoor door in doors)
        {
            if (door != null)
            {
                door.Open();
            }
        }
    }

}
