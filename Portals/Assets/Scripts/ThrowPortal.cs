using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class ThrowPortal : MonoBehaviour {
    
    [SerializeField] GameObject leftPortal;
    [SerializeField] GameObject rightPortal;

    GameObject mainCamera;

	// Use this for initialization
	void Start () {
        mainCamera = GameObject.FindWithTag("MainCamera");
        Assert.IsNotNull(mainCamera);
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("Left click");
            throwPortal(leftPortal);
        }

        if (Input.GetMouseButtonDown(1))
        {
            print("Right click");
            throwPortal(rightPortal);
        }
    }

    private void throwPortal(GameObject portal) {
        
        int x = Screen.width / 2;
        int y = Screen.height / 2;

        Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x, y));
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            Quaternion hitObjectRotation = Quaternion.LookRotation(hit.normal);
            portal.transform.position = hit.point;
            portal.transform.rotation = hitObjectRotation;
        }

    }

}
