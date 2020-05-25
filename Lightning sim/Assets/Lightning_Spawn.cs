using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning_Spawn : MonoBehaviour
{
	public Lightning lightning; //lightning bolt prefab

	private GameObject source;

	private float seconds;

	private Vector3 sourcePosition;

	public int numBolts;   //number of bolts each strike has
	public float timeBetween;  //seconds between each bolt generation



	void Start(){
		        seconds = 0.0f;

	}
 
   void Update(){
   	seconds += Time.deltaTime;
    	if(seconds>=timeBetween){
    		seconds = 0;
    		for(int i = 0; i < numBolts; i++){
    			Instantiate(lightning,sourcePosition,Quaternion.identity);
  			}
    		print("2s ");
    	//updateLineRenderer();
    	}
   }
}
