using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class House : MonoBehaviour
{
    [SerializeField] private float _stepVolume;

    private AudioSource _audioSource;
    private bool _isEmpty = true;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();

        StartCoroutine(Signal());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _isEmpty = false;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _isEmpty = true;
    }

    private IEnumerator Signal()
    {
        while (true)
        {
            if (!_isEmpty)
                _audioSource.volume += _stepVolume;
            else
                _audioSource.volume -= _stepVolume;

            yield return null;
        }
    }
}
