using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleAudio : MonoBehaviour
{
    [SerializeField] private bool _toggleMusic , _toggleEffect ;

    public void Toggle()
    {
        if (_toggleMusic) SoundManager.Instance.ToggleMusic();
        if(_toggleEffect) SoundManager.Instance.ToggleEffect();
    }
}
