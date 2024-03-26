using UnityEngine;

public class WallGenerator : MonoBehaviour
{
    public GameObject boxPrefab;   // Reference to the box prefab
    public float gap = 0.1f;       // Gap between boxes
    void Start()
    {
        // Get the size of the box
        Vector3 boxSize = boxPrefab.transform.localScale;

        for (int y = 0; y < 5; ++y)
        {
            for (int x = 0; x < 8; ++x)
            {
                // Calculate the position with the gap
                float xPos = x * (boxSize.x + gap) * 2.5f;
                float yPos = y * (boxSize.y + gap);
                Vector3 spawnPosition = new Vector3(xPos, yPos, 0);

                // Instantiate the box as a child of the empty GameObject
                GameObject box = Instantiate(boxPrefab, transform);
                box.transform.localPosition = spawnPosition;
                box.transform.Rotate(0, 0, 0); // Rotate 90 degrees around the y-axis

                // Get the renderer of the box
                Renderer renderer = box.GetComponent<Renderer>();

                // Generate a random color
                Color randomColor = new Color(Random.value, Random.value, Random.value);

                // Assign the random color to the box's material
                renderer.material.color = randomColor;
            }
        }
    }
    
}
