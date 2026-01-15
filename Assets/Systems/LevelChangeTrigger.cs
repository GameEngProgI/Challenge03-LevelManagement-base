using UnityEngine;

public class LevelChangeTrigger : MonoBehaviour
{
    public GameObject targetLevel;
    public Transform spawnPoint;



    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("trigger hit");

        // Ensure the trigger is activated only by the player
        if (other.CompareTag("Player"))
        {
            // Trigger the scene change via LevelManager, passing the scene name and spawn point
            ServiceHub.Instance.levelManager.LoadLevel(targetLevel, spawnPoint);


        }
    }



}
