using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BookTrigger : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject redScreen;
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            audioSource.Play();
            var color = redScreen.GetComponent<Image>().color;
            color.a = 0.5f;
            redScreen.GetComponent<Image>().color = color;
            StartCoroutine(ExampleCoroutine());
        }
    }

    IEnumerator ExampleCoroutine()
    {        
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }
}
