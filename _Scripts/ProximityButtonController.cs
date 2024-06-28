using UnityEngine.UI;
using UnityEngine;

public class ProximityButtonController : MonoBehaviour
{
   public GameObject rover; // Reference to the Rover GameObject
    public GameObject rock; // Reference to the Rock GameObject
 

    public Button actionButton; // Reference to the Button component
   public MenuManager menuManager; // Reference to the MenuManager

    public float activationDistance = .1f; // Distance threshold for activation

    private bool isInRange = false; // Flag to track if Rover is in range of Rock


    void Start()
    {
        // Initially deactivate the button
        actionButton.interactable = false;
    }

    void Update()
    {
        
        // Check the distance between Rover and Rock
        float distance = Vector2.Distance(rover.transform.position,rock.transform.position);

        if (distance <= activationDistance && !isInRange)
    {
        actionButton.interactable = true;
        isInRange = true;
       Debug.Log("Button activated!");
    }
    // Deactivate the button if Rover is outside activationDistance of Rock
    else if (distance > activationDistance && isInRange)
    {
        actionButton.interactable = false;
        isInRange = false;
       Debug.Log("Button deactivated!");

        
    }
  
}
}
