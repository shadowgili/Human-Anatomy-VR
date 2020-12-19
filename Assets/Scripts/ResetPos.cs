using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPos : MonoBehaviour
{
    public Vector3 transformPos;
    // Start is called before the first frame update
    void Start()
    {
        transformPos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        //controller button add korey niyen
        if (Input.GetButtonDown("C")) {
            ResetPosition();
        }
        
    }

    public void ResetPosition()
    {
        StartCoroutine(Smooth());           

        /*transform.localPosition = transformPos;
        Debug.Log(transform.position);*/
    }
    IEnumerator Smooth()
    {
        float T = 0f;

        while (T <= 1.0f)
        {
            T += Time.deltaTime / 0.5f;
            transform.localPosition = Vector3.Lerp(transform.localPosition, transformPos, Mathf.SmoothStep(0f, 1f, T));
            yield return null;

        }

    }
}
