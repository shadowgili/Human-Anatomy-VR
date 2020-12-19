using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    public LayerMask RayMask;
    RaycastHit hit;
    Transform currentTransform;
    float length;


    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PickUpObj();
    }

    void PickUpObj() {

        if (Input.GetButtonDown("Jump"))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, 100.0f,RayMask)) {
                if (hit.transform) {
                    SetNewTransform(hit.transform);
                }
            }  
        }

        if (Input.GetButtonDown("Fire"))
            {
                RemoveTransform();
            }

        if (currentTransform)
            MoveTransformAround();

    }

    public void SetNewTransform(Transform newTransform) {
        if (currentTransform)
            return;

        currentTransform = newTransform;
        length = Vector3.Distance(transform.position, newTransform.position);

        currentTransform.GetComponent<Rigidbody>().isKinematic = true;
    }

    private void MoveTransformAround() {
        currentTransform.position = transform.position + transform.forward * length;
    }
    public void RemoveTransform() {
        if (!currentTransform)
            return;
        //currentTransform.GetComponent<Rigidbody>().isKinematic = false;
        currentTransform = null;
    }
}
