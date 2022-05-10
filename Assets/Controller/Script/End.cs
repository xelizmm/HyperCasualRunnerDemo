using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{

    [SerializeField] GameObject _balloon;
    [SerializeField] GameObject _panel;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GetComponent<Movement>().enabled = false; 
            
            _balloon.SetActive(true);
            _panel.SetActive(true);
        }
    }
}
