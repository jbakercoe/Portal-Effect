using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepThroughPortal : MonoBehaviour {

    [SerializeField] GameObject otherPortal;
    [SerializeField] Transform player;

    private new Camera camera;

	// Use this for initialization
	void Start () {
        camera = GetComponentInChildren<Camera>();
	}

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = otherPortal.transform.position + (otherPortal.transform.forward * 2);
            other.transform.rotation = otherPortal.transform.rotation;
        }
    }

}
