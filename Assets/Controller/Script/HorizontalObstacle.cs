using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalObstacle : MonoBehaviour
{
    [SerializeField] GameObject _gameOver;
    [SerializeField] GameObject _player;

    [SerializeField] GameObject _npcStart;
    [SerializeField] GameObject _npcPlayer;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _player.SetActive(false);
            _gameOver.SetActive(true);
        }

        if (collision.gameObject.CompareTag("NPCPlayer"))
        {
            teleport();
        }
    }

    void teleport()
    {
        _npcPlayer.gameObject.SetActive(false);
        _npcPlayer.transform.position = _npcStart.transform.position;
        _npcPlayer.gameObject.SetActive(true);
    }

    void Update()
    {
        transform.Rotate(0, 1, 0);
    }
}
