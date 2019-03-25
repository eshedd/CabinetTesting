using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cabinet : MonoBehaviour
{
    public GameObject closed;
    public GameObject open1;
    public GameObject open2;
    public GameObject open3;
    public GameObject open4;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;

    public void OnClick1()
    {
        if (open1.activeSelf)
        {
            open1.SetActive(false);
            closed.SetActive(true);
        }
        else
        {
            open1.SetActive(true);
            closed.SetActive(false);
            open2.SetActive(false);
            open3.SetActive(false);
            open4.SetActive(false);
        }
    }
    public void OnClick2()
    {
        if (open2.activeSelf)
        {
            open2.SetActive(false);
            closed.SetActive(true);
        }
        else
        {
            open2.SetActive(true);
            closed.SetActive(false);
            open1.SetActive(false);
            open3.SetActive(false);
            open4.SetActive(false);
        }
    }
    public void OnClick3()
    {
        if (open3.activeSelf)
        {
            open3.SetActive(false);
            closed.SetActive(true);
        }
        else
        {
            open3.SetActive(true);
            closed.SetActive(false);
            open2.SetActive(false);
            open1.SetActive(false);
            open4.SetActive(false);
        }
    }
    public void OnClick4()
    {
        if (open4.activeSelf)
        {
            open4.SetActive(false);
            closed.SetActive(true);
        }
        else
        {
            open4.SetActive(true);
            closed.SetActive(false);
            open1.SetActive(false);
            open2.SetActive(false);
            open3.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
