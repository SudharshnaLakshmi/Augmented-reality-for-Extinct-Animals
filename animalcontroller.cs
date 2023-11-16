using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animalcontroller : MonoBehaviour
{
    public GameObject animal1;
    public GameObject animal2;

    bool isleftPressed;
    bool isrightPressed;
    bool isforwardPressed;

    // Start is called before the first frame update
    void Start()
    {
        isleftPressed = false;
        isrightPressed = false;
        isforwardPressed = false;
    }
    public void OnleftPressed()
    {
        isleftPressed = true;
    }
    public void OnleftReleased()
    {
        isleftPressed = false;
    }
    public void OnrightPressed()
    {
        isrightPressed = true;
    }
    public void OnrightReleased()
    {
        isrightPressed = false;
    }
    public void OnforwardPressed()
    {
        isforwardPressed = true;
    }
    public void OnforwardReleased()
    {
        isforwardPressed = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (isleftPressed == true)
        {
            animal1.transform.Rotate(new Vector3(0f, 45f, 0f) * Time.deltaTime);
            animal2.transform.Rotate(new Vector3(0f, 45f, 0f) * Time.deltaTime);
        }
        if (isrightPressed == true)
        {
            animal1.transform.Rotate(new Vector3(0f, -45f, 0f) * Time.deltaTime);
            animal2.transform.Rotate(new Vector3(0f, -45f, 0f) * Time.deltaTime);
        }
        if (isforwardPressed == true)
        {
            animal1.transform.Translate(new Vector3(0f, 0f, -3f) * Time.deltaTime, Space.Self);
            animal2.transform.Translate(new Vector3(0f, 0f, 3f) * Time.deltaTime, Space.Self);

        }

    }

}
