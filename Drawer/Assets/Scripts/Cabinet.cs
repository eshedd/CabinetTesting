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
    public Sprite aiden1;
    public Sprite aiden2;
    public Sprite aiden3;
    public Sprite aiden4;
    public Sprite dominic1;
    public Sprite dominic2;
    public Sprite dominic3;
    public Sprite dominic4;
    public Sprite daniel1;
    public Sprite daniel2;
    public Sprite daniel3;
    public Sprite daniel4;
    public Sprite sam1;
    public Sprite sam2;
    public Sprite sam3;
    public Sprite sam4;
    public string url1;
    public string url2;
    public string url3;
    public string url4;

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
        Application.OpenURL (url1);
    }
    public void OnClick6 () {
        Application.OpenURL (url2);
    }
    public void OnClick7 () {
        Application.OpenURL (url3);
    }
    public void OnClick8 () {
        Application.OpenURL (url4);
    }
    // Start is called before the first frame update
    void Start () {
        int person = URLParameters.GetSearchParameters ().GetInt ("person", 2);
        switch (person) {
            case 1:
                {
                    project1.GetComponent<Image> ().sprite = ethan1;
                    project2.GetComponent<Image> ().sprite = ethan2;
                    project3.GetComponent<Image> ().sprite = ethan3;
                    project4.GetComponent<Image> ().sprite = ethan4;
                    project1.transform.GetChild (0).GetComponent<Text> ().text = "HelpOut";
                    project2.transform.GetChild (0).GetComponent<Text> ().text = "Personal Site";
                    project3.transform.GetChild (0).GetComponent<Text> ().text = "Robotics Scouting App";
                    project4.transform.GetChild (0).GetComponent<Text> ().text = "Currency Trader";
                    url1 = "https://eshedd.github.io/HelpOut/";
                    url2 = "https://eshedd.github.io/WebDesignClass/";
                    url3 = "https://github.com/eshedd/ScoutingAppRobotics";
                    url4 = "https://coinshedd.weebly.com/";
                }
                break;
            case 2:
                {
                    project1.GetComponent<Image> ().sprite = aiden1;
                    project2.GetComponent<Image> ().sprite = aiden2;
                    project3.GetComponent<Image> ().sprite = aiden3;
                    project4.GetComponent<Image> ().sprite = aiden4;
                    project1.transform.GetChild (0).GetComponent<Text> ().text = "Personal Site";
                    project2.transform.GetChild (0).GetComponent<Text> ().text = "TEDx App";
                    project3.transform.GetChild (0).GetComponent<Text> ().text = "TEDx DTHS";
                    project4.transform.GetChild (0).GetComponent<Text> ().text = "Personal Cloud Platform";
                    url1 = "http://aidenappleby.com";
                    url2 = "https://app.tedxdesigntechhighschool.us";
                    url3 = "http://edxdesigntechhighschool.us";
                    url4 = "http://aiden.cloud";
                }
                break;
            case 3:
                {
                    project1.GetComponent<Image> ().sprite = dominic1;
                    project2.GetComponent<Image> ().sprite = dominic2;
                    project3.GetComponent<Image> ().sprite = dominic3;
                    project4.GetComponent<Image> ().sprite = dominic4;
                    project1.transform.GetChild (0).GetComponent<Text> ().text = "Random Game";
                    project2.transform.GetChild (0).GetComponent<Text> ().text = "Softbody Pong";
                    project3.transform.GetChild (0).GetComponent<Text> ().text = "Pong and Breakout Site";
                    project4.transform.GetChild (0).GetComponent<Text> ().text = "Physics Engine";
                    url1 = "https://github.com/Dominic-b/Pong/tree/secondary ";
                    url2 = "https://github.com/Dominic-b/Project-Game ";
                    url3 = "https://github.com/Dominic-b/Pong-Website";
                    url4 = "https://github.com/Dominic-b/Physics-Engine";
                }
                break;
            case 4:
                {
                    project1.GetComponent<Image> ().sprite = daniel1;
                    project2.GetComponent<Image> ().sprite = daniel2;
                    project3.GetComponent<Image> ().sprite = daniel3;
                    project4.GetComponent<Image> ().sprite = daniel4;
                    project1.transform.GetChild (0).GetComponent<Text> ().text = "HelpOut";
                    project2.transform.GetChild (0).GetComponent<Text> ().text = "Personal Site";
                    project3.transform.GetChild (0).GetComponent<Text> ().text = "Robotics Scouting App";
                    project4.transform.GetChild (0).GetComponent<Text> ().text = "Currency Trader";
                    url1 = "";
                    url2 = "";
                    url3 = "";
                    url4 = "";
                }
                break;
            case 5:
                {
                    project1.GetComponent<Image> ().sprite = sam1;
                    project2.GetComponent<Image> ().sprite = sam2;
                    project3.GetComponent<Image> ().sprite = sam3;
                    project4.GetComponent<Image> ().sprite = sam4;
                    project1.transform.GetChild (0).GetComponent<Text> ().text = "HelpOut";
                    project2.transform.GetChild (0).GetComponent<Text> ().text = "Personal Site";
                    project3.transform.GetChild (0).GetComponent<Text> ().text = "Robotics Scouting App";
                    project4.transform.GetChild (0).GetComponent<Text> ().text = "Currency Trader";
                    url1 = "";
                    url2 = "";
                    url3 = "";
                    url4 = "";
                }
                break;
        }
        Debug.Log (person);
    }

    // Update is called once per frame
    void Update () {

    }
}