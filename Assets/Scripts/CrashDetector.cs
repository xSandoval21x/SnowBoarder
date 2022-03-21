using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float delay = 1f;
    [SerializeField] ParticleSystem crashEffect;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Environment")
        {
            crashEffect.Play();
            Invoke("ReloadScene", delay);

        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
