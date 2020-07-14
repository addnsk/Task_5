using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    [SerializeField] private Thief _thief;
    [SerializeField] private float _stepVolume;
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        if (_thief.isHouse)
            _audioSource.volume += _stepVolume;
        else
            _audioSource.volume -= _stepVolume;
    }
}
