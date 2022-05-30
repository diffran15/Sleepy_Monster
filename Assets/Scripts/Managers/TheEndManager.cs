using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheEndManager : EnemyHealth
{
    public GameObject theEndPanel;

    //public AudioSource winningSound;

    private void Start()
    {
        //winningSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //winningSound.Play();
            theEndPanel.SetActive(true);
            Time.timeScale = 0f;
            Invoke("CompleteLevel", 2f);
        }
    }
}
