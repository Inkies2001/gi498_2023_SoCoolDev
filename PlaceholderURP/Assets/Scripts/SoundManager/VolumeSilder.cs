using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSilder : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider;

    void Start()
    {
        
        SoundManager.Instance.ChangeMasterVolume(volumeSlider.value);
        
        volumeSlider.onValueChanged.AddListener(val  => SoundManager.Instance.ChangeMasterVolume(val));
    }

}
