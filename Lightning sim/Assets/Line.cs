using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    public Color c1;
    public Color c2;
    public int lineSegments;
    protected Vector3 startLocation;
    protected GameObject source;
    public float lengthOfSegment;
    protected List<Vector3> positions = new List<Vector3>();
    private Vector3 currentPos;
    protected LineRenderer lineRenderer;
    private float seconds;
    private int count =0;
    public Material zap;


    void Start()
    {
    	
        lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
        lineRenderer.widthMultiplier = 0.2f;
   //     Random.InitState(42);
        seconds = 0.0f;
		        // A simple 2 color gradient with a fixed alpha of 1.0f.
        float alpha = 1.0f;
       Gradient gradient = new Gradient();
        gradient.SetKeys(
            new GradientColorKey[] { new GradientColorKey(c1, 0.0f), new GradientColorKey(c2, 1.0f) },
            new GradientAlphaKey[] { new GradientAlphaKey(alpha, 0.0f), new GradientAlphaKey(alpha, 1.0f) }
        );
        lineRenderer.colorGradient = gradient; //set gradient*/
       print(lineRenderer);
		       lineRenderer.material= zap;


    
        source = GameObject.Find("LightningSource");  // set the source of the lightning to the source object
        startLocation = source.transform.position;  //save the startLocation for the lightning bolt
        print("start location "+ startLocation);// some debugging

        positions.Add(startLocation); //add the initial location to our position array which will be edited behind the scenes
        currentPos = startLocation; // this saves the current position to our startLocation initially;
        generatePositions(currentPos);
        lineRenderer.positionCount = positions.Count;
        updateLineRenderer();
        


   		 


    }

    void Update()
    {
     //   LineRenderer lineRenderer = GetComponent<LineRenderer>();
       	
    	//print(Time.deltaTime);
		seconds += Time.deltaTime;
    	/*if(seconds>=2.0){
    		count ++;
    		print("2s have passed " + count);
    		seconds = 0;
    		generatePositions(startLocation);
    		updateLineRenderer();
    	}*/
     	
    }

    void generatePositions(Vector3	startLocation)
    {
    	//Vector3 newLocation;
    	positions.Clear();
    	int pos = (int)Random.Range(10.0f,18.0f);
    	pos = 2;
    	lineSegments = pos;
    	    	print(pos);

    	 for( int i = 0; i <= pos; i ++){
    	   float locX = Random.Range(-1.0f,1.0f);
    	   
    	   	      
           		positions.Add(currentPos = new Vector3(currentPos.x - locX,currentPos.y -lengthOfSegment,currentPos.z));
           	


        }
        currentPos = startLocation;
    }

    void updateLineRenderer(){
    	lineRenderer.positionCount=lineSegments;
    	lineRenderer.SetPosition(0, startLocation);
    	for (int i = 1; i < lineSegments; i++)

        {
        	lineRenderer.SetPosition(i, positions[i-1]);
        }
               
    }

}
