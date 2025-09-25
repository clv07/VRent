using UnityEngine;

public class RetrieveFurniture : MonoBehaviour
{
    public GameObject furniturePrefab;

    public float offset = 1.2f;
    public void SpawnFurnitureInFront()
    {
        Debug.Log("Here in the spawn furniture in front function");
        if (furniturePrefab == null)
        {
            Debug.LogError("No furniture prefab assigned.");
            return;
        }

        Transform cameraTransform = Camera.main.transform;
        Vector3 forwardPosition = cameraTransform.position + cameraTransform.forward * offset;
        Vector3 spawnPosition = cameraTransform.position + cameraTransform.forward * offset;
        spawnPosition.y = cameraTransform.position.y - 0.5f;  // Adjust this offset as needed to spawn on the ground
        Quaternion spawnRotation = Quaternion.identity;

        GameObject spawnedFurniture = Instantiate(furniturePrefab, spawnPosition, spawnRotation);
        spawnedFurniture.SetActive(true);
    }
}
