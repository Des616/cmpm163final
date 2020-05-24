using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : MonoBehaviour
{
   private LineRenderer lineRenderer;

   private int numSegs= 12;

   private Color color = Color.white;

    private GameObject source;

   private Vector3 sourcePosition;

   private Vector3 currentPos; //where we are currently




    void Start()
    {
    	lineRenderer = GetComponent<LineRenderer>();

    	lineRenderer.positionCount = numSegs;

    	source = GameObject.Find("LightningSource");  // set the source of the lightning to the source object
        sourcePosition= source.transform.position;
        currentPos = sourcePosition;
     //   print(sourcePosition);

        

    	for(int i = 1; i < numSegs ; ++i){
    		float locX = Random.Range(-1.0f,1.0f);
    		lineRenderer.SetPosition(i,currentPos = new Vector3(currentPos.x - locX,currentPos.y - Random.Range(1.0f,2.0f),currentPos.z));
    	}
    	lineRenderer.SetPosition(0,sourcePosition);
    	
        
    }

    // Update is called once per frame
  void Update()

    {
	
	    	color.a -= 10f * Time.deltaTime;
      lineRenderer.SetColors(color,color);
    	if(color.a <= 0f && this.gameObject){
    	//	Destroy(this.gameObject);
    	}    
    }
}

