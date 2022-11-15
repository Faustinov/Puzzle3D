using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundSource : MonoBehaviour
{
    [SerializeField] private GameObject _sound;
    [SerializeField] private GameObject _nonsound;

    public void OnSound()
    {
        _sound.SetActive(true);
        _nonsound.SetActive(false);
        AudioListener.volume = 0.3f;
    }

    public void OffSound()
    {
        _sound.SetActive(false);
        _nonsound.SetActive(true);
        AudioListener.volume = 0;
    }
}
