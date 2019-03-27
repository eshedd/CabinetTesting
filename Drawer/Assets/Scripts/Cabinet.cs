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
    public Sprite ethan1;
    public Sprite ethan2;
    public Sprite ethan3;
    public Sprite ethan4;
    public Sprite dominic1;
    public Sprite dominic2;
    public Sprite dominic3;
    public Sprite dominic4;
    public Sprite daniel1;
    public Sprite daniel2;
    public Sprite daniel3;
    public Sprite daniel4;
    public Sprite aiden1;
    public Sprite aiden2;
    public Sprite aiden3;
    public Sprite aiden4;

    public void OnClick1 () {
        if (open1.activeSelf) {
            setActiveGroup (open1, project1, false);
            closed.SetActive (true);
        } else {
            closed.SetActive (false);
            setActiveGroup (open1, project1, true);
            setActiveGroup (open2, project2, false);
            setActiveGroup (open3, project3, false);
            setActiveGroup (open4, project4, false);
        }
    }
    public void OnClick2 () {
        if (open2.activeSelf) {
            setActiveGroup (open2, project2, false);
            closed.SetActive (true);
        } else {
            closed.SetActive (false);
            setActiveGroup (open1, project1, false);
            setActiveGroup (open2, project2, true);
            setActiveGroup (open3, project3, false);
            setActiveGroup (open4, project4, false);
        }
    }
    public void OnClick3 () {
        if (open3.activeSelf) {
            setActiveGroup (open3, project3, false);
            closed.SetActive (true);
        } else {
            closed.SetActive (false);
            setActiveGroup (open1, project1, false);
            setActiveGroup (open2, project2, false);
            setActiveGroup (open3, project3, true);
            setActiveGroup (open4, project4, false);
        }
    }
    public void OnClick4 () {
        if (open4.activeSelf) {
            setActiveGroup (open4, project4, false);
            closed.SetActive (true);
        } else {
            setActiveGroup (closed, project1, false);
            setActiveGroup (open1, project1, false);
            setActiveGroup (open2, project2, false);
            setActiveGroup (open3, project3, false);
            setActiveGroup (open4, project4, true);
        }
    }

    public void setActiveGroup (GameObject Cabinet, Button Icon, bool active) {
        Cabinet.SetActive (active);
        Icon.gameObject.SetActive (active);
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
        int person = URLParameters.GetSearchParameters().GetInt ("person", 2);
        switch (person) {
            case 1:
                {
                    project1.GetComponent<SpriteRenderer>().sprite = ethan1;
                    project2.GetComponent<SpriteRenderer>().sprite = ethan2;
                    project3.GetComponent<SpriteRenderer>().sprite = ethan3;
                    project4.GetComponent<SpriteRenderer>().sprite = ethan4;
                }
                break;
            case 2:
                {
                    project1.GetComponent<SpriteRenderer>().sprite = aiden1;
                    project2.GetComponent<SpriteRenderer>().sprite = aiden2;
                    project3.GetComponent<SpriteRenderer>().sprite = aiden3;
                    project4.GetComponent<SpriteRenderer>().sprite = aiden4;
                }
                break;
            case 3:
                {

                }
                break;
            case 4:
                {

                }
                break;
            case 5:
                {

                }
                break;
        }
        Debug.Log (person);
    }

    // Update is called once per frame
    void Update () {

    }
}