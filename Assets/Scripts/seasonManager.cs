using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seasonManager : MonoBehaviour
{
    public GameObject season1;
    public GameObject season2;
    public GameObject season3;

    private int season;
    // Start is called before the first frame update
    void Start()
    {
        season = 0;
        SetActive();
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch)){
            season = (season + 1) % 3;
            SetActive();
        };
        
    }

    void SetActive() {
        season1.active = (season == 0);
        season2.active = (season == 1);
        season3.active = (season == 2);
    }
}
