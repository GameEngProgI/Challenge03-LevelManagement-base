using UnityEngine;


public class LevelManager : MonoBehaviour
{
    [Header("Levels")]
    [SerializeField] GameObject level01;
    [SerializeField] GameObject level02;

    private GameObject player;

    private GameObject currentActiveLevel;

    public Transform defaultSpawn;

    private void Awake()
    {
        player = ServiceHub.Instance.playerController.gameObject;
    }


    public void Start()
    {

        // initlialize first level 

    

        LoadLevel(level01, defaultSpawn);
    }

    public void LoadLevel(GameObject newLevel, Transform newSpawnPosition)
    {
        if (newLevel == null)
        {
            Debug.LogWarning("LevelManager.LoadLevel called with null newLevel. Aborting.");
            return;
        }


        if (currentActiveLevel != null) 
        {
            currentActiveLevel.SetActive(false);
        }

        MovePlayerToSpawn(newSpawnPosition);

           
        currentActiveLevel = newLevel;        

        currentActiveLevel.SetActive(true);

    }  


    private void MovePlayerToSpawn(Transform newSpawnPosition)
    {
        if (player == null)
        {
            Debug.LogWarning("LevelManager.MovePlayerToSpawn: player reference is null.");
            return;
        }


        player.transform.position = newSpawnPosition.position;
    }

    

}
