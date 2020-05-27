using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System.Text;
using System.Net;
public class MovementTracker : MonoBehaviour
{
    public StatManager statMngr;
    public GameObject controllerRight;
    public GameObject controllerLeft;
    public GameObject mainBody;

    public float movedCR = 0.0f;
    public float movedCL = 0.0f;
    public float movedB = 0.0f;


    Vector3 controllerRlast;
    Vector3 controllerLlast;
    Vector3 bodylast;


    void Start()
    {
        controllerLlast = controllerLeft.transform.localPosition;
        controllerRlast = controllerRight.transform.localPosition;
        bodylast = mainBody.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (statMngr.Time < 0)
        {
            EndGame();
        }

        statMngr.Time -= Time.deltaTime;
        
        // Right Controller
        movedCR += (Vector3.Distance(controllerRlast, controllerRight.transform.localPosition));
        controllerRlast = controllerRight.transform.localPosition;

        // Left Controller
        movedCL += (Vector3.Distance(controllerLlast, controllerLeft.transform.localPosition));
        controllerLlast = controllerLeft.transform.localPosition;

        // Body
        movedB += (Vector3.Distance(bodylast, mainBody.transform.localPosition));
        bodylast = mainBody.transform.localPosition;
    }

    void EndGame()
    {
        string path = Application.persistentDataPath + "/Sessiondata.datMyFile";
        FileStream stream = new FileStream(path, FileMode.Create);
        byte[] buffer = ASCIIEncoding.ASCII.GetBytes("Date: " + System.DateTime.Now.ToString() + ", ControllerRight: " + movedCR + ", ControllerLeft: " + movedCL + ", Body: " + movedB + ", Score: " + statMngr.Score);
        stream.Write(buffer, 0 , buffer.Length);
        stream.Close();

        SceneManager.LoadScene(0);
       
    }



    
}
