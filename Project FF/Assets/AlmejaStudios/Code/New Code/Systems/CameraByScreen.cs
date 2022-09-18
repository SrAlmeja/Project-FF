using System;
using System.Collections;
using UnityEngine;

public class CameraByScreen : MonoBehaviour
{
    public GameObject camLandscape;
    public GameObject camPortail;
    public GameObject defaultCam;
    Vector2 res;

    private void Awake()
    {
        res = new Vector2(Screen.width, Screen.height);
        defaultCam.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (res.x > res.y)
        {
            camLandscape.SetActive(true);
            camPortail.SetActive(false);
        }
        if (res.x < res.y)
        {
            camLandscape.SetActive(false);
            camPortail.SetActive(true);
        }
    }
}
