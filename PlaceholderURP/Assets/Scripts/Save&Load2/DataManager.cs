using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;


    private void Awake()
    {
        instance = this;
    }
    
    public void SaveData (Data data)
    {
        string dataToSave = JsonUtility.ToJson (data);
        File.WriteAllText(Application.persistentDataPath + Path.DirectorySeparatorChar + "dataFile.jason", dataToSave);
        Debug.Log(" 'SAVE' ");
    }

    public Data LoadData ()
    {
        Data data = new Data();
        
        if (File.Exists(Application.persistentDataPath + Path.DirectorySeparatorChar + "dataFile.json"))
        {
            string dataString = File.ReadAllText(Application.persistentDataPath + Path.DirectorySeparatorChar + "dataFile.json");
            data = JsonUtility.FromJson<Data>(dataString);
        }

        return data;
    }
}
