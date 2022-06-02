using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public AudioSource audioSource;
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            audioSource.Play();
            StartCoroutine(ExampleCoroutine());
        }
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(2);
    }
}
