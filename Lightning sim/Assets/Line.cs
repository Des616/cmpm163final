using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{

	public Vector3 yOrigin;

    // Start is called before the first frame update
    void Start()
    {
        transform.localPosition = yOrigin;
        Debug.Log(yOrigin);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
