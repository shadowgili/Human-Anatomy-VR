using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VRLookWalk : MonoBehaviour
{

    public Transform vrCamera;
    public float speed = 3.0f;

    private CharacterController cc;
    public bool isPlay;
    public bool isStartPanel;
    public bool isOptionPanel;
    public bool isSphere;
    public GameObject panel, sphere, ControllerPanel;

    // Use this for initialization
    void Start()
    {
        
        isStartPanel = true;
        isOptionPanel = false;
        isPlay = false;
        ControllerPanel.SetActive(false);
        sphere.SetActive(true);
        isSphere = true;
        
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlay)
        {
            if (Input.GetAxis("Horizontal") < 0)
            {
                cc.transform.Rotate(new Vector3(0, -90, 0) * Time.deltaTime);
            }


            if (Input.GetAxis("Horizontal") > 0)
            {
                cc.transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime);
            }

            if (Input.GetAxis("Vertical") < 0)
            {
                Vector3 forward = vrCamera.TransformDirection(Vector3.back);
                cc.SimpleMove(forward * speed);
            }


            if (Input.GetAxis("Vertical") > 0)
            {
                Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
                cc.SimpleMove(forward * speed);
            }

            if (Input.GetButtonDown("B"))
            {
                isStartPanel = true;
                isPlay = false;
                panel.gameObject.SetActive(true);

            }
        }

        if (isStartPanel)
        {
            //StartButton
            if (Input.GetButtonDown("A"))
            {
                panel.gameObject.SetActive(false);
                isPlay = true;
                isStartPanel = false;
                sphere.SetActive(false);
                isSphere = false;
            }
            //OptionButton
            if (Input.GetButtonDown("D"))
            {
                isOptionPanel = true;
                isStartPanel = false;
                sphere.SetActive(true);

            }
            //ExitButton
            if (Input.GetButtonDown("B"))
            {
                Application.Quit();
            }
        }

        if (isOptionPanel)
        {
            panel.gameObject.SetActive(false);
            ControllerPanel.SetActive(true);


            if (Input.GetButtonDown("B"))
            {
                isStartPanel = true;
                panel.gameObject.SetActive(true);
                ControllerPanel.SetActive(false);
                isOptionPanel = false;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

        }

    }

    public void StartButton()
    {
        if (isStartPanel) {
            panel.gameObject.SetActive(false);
            isPlay = true;
            isStartPanel = false;
        }
    }

    public void OptionButton()
    {
        if (isStartPanel) {
            isOptionPanel = true;
            isStartPanel = false;
        }
    }
    public void ExitButton()
    {
        if (isStartPanel) {
            Application.Quit();
        }
        
    }

    public void BackButton() {
        isStartPanel = true;
        panel.gameObject.SetActive(true);
        ControllerPanel.SetActive(false);
        isOptionPanel = false;
    }
}
