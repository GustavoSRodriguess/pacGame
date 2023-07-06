using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class jumpscareSound : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        Invoke("PlayDelayedSound", 1);
    }

    void PlayDelayedSound()
    {
        audioSource.Play();
    }
}
