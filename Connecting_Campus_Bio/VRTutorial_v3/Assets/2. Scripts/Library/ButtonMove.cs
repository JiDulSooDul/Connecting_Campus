using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;
using UnityEngine.SceneManagement;

public class ButtonMove : MonoBehaviour
{
    public GameObject cam;
    public GameObject landmarkspot;
    public GameObject lectureroomspot;
    public GameObject medicalroomspot;
    public GameObject libraryspot;
    public GameObject tecspot;
    public GameObject cafeteriaspot;
    public GameObject postofficespot;
    public GameObject labspot;

    bool landmark = false;
    bool lectureroom = false;
    bool medicalroom = false;
    bool library = false;
    bool tec = false;
    bool cafeteria = false;
    bool postoffice = false;
    bool lab = false;

    public void Update()
    {
       /* if (landmark)
        {
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, landmarkspot.transform.position, Time.deltaTime * 100f);
            Invoke("MoveMedicalroom", 5);
        }*/
        if (lectureroom)
        {
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, lectureroomspot.transform.position, Time.deltaTime * 100f);
            Invoke("Lectureroom", 5);
        }
        if (medicalroom)
        {
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, medicalroomspot.transform.position, Time.deltaTime * 100f);
            Invoke("MoveMedicalroom", 5);
        }
        if (library)
        {
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, libraryspot.transform.position, Time.deltaTime * 100f);
            Invoke("Library", 5);
        }
        if (tec)
        {
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, tecspot.transform.position, Time.deltaTime * 100f);
            Invoke("Tec", 5);
        }
        if (cafeteria)
        {
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, cafeteriaspot.transform.position, Time.deltaTime * 100f);
            Invoke("Cafeteria", 5);
        }

        if (postoffice)
        {
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, postofficespot.transform.position, Time.deltaTime * 100f);
            Invoke("Postoffice", 5);
        }

        if (lab)
        {
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, labspot.transform.position, Time.deltaTime * 100f);
            Invoke("Lab", 5);
        }
    }

    public void landmarkmove()
    {
        landmark = true;
    }
    public void lectureroommove()
    {
        lectureroom = true;
    }
    public void healthroommove()
    {
        medicalroom = true;
    }
    public void librarymove()
    {
        library = true;
    }
    public void tecmove()
    {
        tec = true;
    }
    public void cafeteriamove()
    {
        cafeteria = true;
    }
    public void postofficemove()
    {
        postoffice = true;
    }
    public void labmove()
    {
        lab = true;
    }

    public void MoveMedicalroom()
    {
        SceneManager.LoadScene("MedicalRoom");
    }

    public void Lectureroom()
    {
        SceneManager.LoadScene(1);
    }

    public void Library()
    {
        SceneManager.LoadScene(8);
    }

    public void Tec()
    {
        SceneManager.LoadScene(7);
    }

    public void Cafeteria()
    {
        SceneManager.LoadScene(3);
    }

    public void Postoffice()
    {
        SceneManager.LoadScene(6);
    }

    public void Lab()
    {
        SceneManager.LoadScene(9);
    }
}
