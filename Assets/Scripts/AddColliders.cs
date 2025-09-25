using UnityEngine;

public class AddFloorColliders : MonoBehaviour
{
    public Transform rootNode;
    void Start()
    {
        if (rootNode == null)
        {
            Debug.LogError("Root node is not assigned.");
            return;
        }

        foreach (Transform child in rootNode.GetComponentsInChildren<Transform>())
        {
            if (child.name.StartsWith("floor_") | child.name.StartsWith("wall_") | child.name.StartsWith("door_"))
            {
                if (child.GetComponent<MeshCollider>() == null)
                {
                    MeshCollider collider = child.gameObject.AddComponent<MeshCollider>();
                    collider.convex = false;
                    // Debug.Log("Added MeshCollider to: " + child.name);
                }
            }
        }
    }
}
