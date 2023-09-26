using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DataPersistance : MonoBehaviour
{
    public static DataPersistance Instance { get; private set; }

    private PlayerData2 gameData;

    private List<IDataPersistence> dataPersistenceObjects;

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("Found more than one data Persistence Manager in the scene.");
        }
        Instance = this;
    }

    private void Start()
    {
        this.dataPersistenceObjects = FindAllDataPersistenceObjects();
        LoadGame();
    }

    public void NewGame()
    {
        this.gameData = new PlayerData2();
    }
    public void LoadGame()
    {
        //if no data can be Loaded , initialize to a new game
        if (this.gameData == null)
        {
            Debug.Log("No data was found. Initializing data to defaults.");
            NewGame();
        }
    }
    public void SaveGame()
    {

    }

    private void OnApplicationQuit()
    {
        SaveGame();
    }

    private List<IDataPersistence> FindAllDataPersistenceObjects()
    {
       // IEnumerable<IDataPersistence> dataPersistenceObjects = FindObjectOfType<MonoBehaviour>().OfType<IDataPersistence>();

        return new List<IDataPersistence>(dataPersistenceObjects);
    } 
}


