using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberManager : MonoBehaviour
{
    int number = 0;
    [SerializeField] Text numberText;
    

    Data data;

    // Start is called before the first frame update
    void Start()
    {
        data = new Data();
        data = DataManager.instance.LoadData();
        number = data.number;
        numberText.text = number.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementNumber()
    {
        number += 1;
        numberText.text  = number.ToString();
    }

    public void SaveData()
    {
        data.number = number;
        DataManager.instance.SaveData(data);
    }
}
