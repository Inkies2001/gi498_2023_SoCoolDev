using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDataPersistence
{
    void LoadData(PlayerData2 data);
    void SaveData(ref PlayerData2 data);
}
