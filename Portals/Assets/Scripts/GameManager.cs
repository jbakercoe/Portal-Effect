using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    [SerializeField] private Transform spawnPoint;
    [SerializeField] GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Restart()
    {
        player.transform.position = spawnPoint.transform.position;
    }

    public void Quit()
    {
        Application.Quit();
    }

}
