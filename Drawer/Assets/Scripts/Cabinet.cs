using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cabinet : MonoBehaviour {
    public GameObject closed;
    public GameObject open1;
    public GameObject open2;
    public GameObject open3;
    public GameObject open4;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button project1;
    public Button project2;
    public Button project3;
    public Button project4;

    public void OnClick1 () {
        if (open1.activeSelf) {
            setActiveGroup(open1, project1, false);
            closed.SetActive (true);
        } else {
            closed.SetActive (false);
            setActiveGroup(open1, project1, true);
            setActiveGroup(open2, project2, false);
            setActiveGroup(open3, project3, false);
            setActiveGroup(open4, project4, false);

        }
    }
    public void OnClick2 () {
        if (open2.activeSelf) {
            setActiveGroup(open2, project2, false);
            closed.SetActive (true);
        } else {
            closed.SetActive (false);
            setActiveGroup(open1, project1, false);
            setActiveGroup(open2, project2, true);
            setActiveGroup(open3, project3, false);
            setActiveGroup(open4, project4, false);
        }
    }
    public void OnClick3 () {
        if (open3.activeSelf) {
            setActiveGroup(open3, project3, false);
            closed.SetActive (true);
        } else {
            closed.SetActive (false);
            setActiveGroup(open1, project1, false);
            setActiveGroup(open2, project2, false);
            setActiveGroup(open3, project3, true);
            setActiveGroup(open4, project4, false);
        }
    }
    public void OnClick4 () {
        if (open4.activeSelf) {
            setActiveGroup(open4, project4, false);
            closed.SetActive (true);
        } else {
            setActiveGroup(closed, project1, false);
            setActiveGroup(open1, project1, false);
            setActiveGroup(open2, project2, false);
            setActiveGroup(open3, project3, false);
            setActiveGroup(open4, project4, true);
        }
    }

    public void setActiveGroup (GameObject Cabinet, Button Icon, bool active) {
        Cabinet.SetActive(active);
        Icon.gameObject.SetActive(active);
    }

    public void OnClick5 () {
        if (open4.activeSelf) {

        } else {

        }
    }
    public void OnClick6 () {
        if (open4.activeSelf) {

        } else {

        }
    }
    public void OnClick7 () {
        if (open4.activeSelf) {

        } else {

        }
    }
    public void OnClick8 () {
        if (open4.activeSelf) {

        } else {

        }
    }
    // Start is called before the first frame update
    void Start () {
        // int pm = Application.absoluteURL.IndexOf("?");
        // if (pm != -1)
        // {
        //     sceneName = Application.absoluteURL.Split("?"[0])[1];
        // }

    }

    // Update is called once per frame
    void Update () {

    }
}