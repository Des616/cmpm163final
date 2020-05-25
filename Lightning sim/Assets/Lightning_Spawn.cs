using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning_Spawn : MonoBehaviour
{
	public Lightning lightning;

	private GameObject source;

	private float seconds;

	private Vector3 sourcePosition;

	public int numBolts;   //number of bolts each strike has

	public int timeBetween;  //seconds between each bolt generation



	void Start(){
		        seconds = 0.0f;

	}
    // Start is called before the first frame update
  /* IEnumerator Start(){
   //	source = GameObject.Find("LightningSource");  // set the source of the lightning to the source object
  //      sourcePosition= source.transform.position;
   	while(true){
   		Instantiate(lightning,sourcePosition,Quaternion.identity);
  	//	Instantiate(lightning,sourcePosition,Quaternion.identity);
 	//	Instantiate(lightning,sourcePosition,Quaternion.identity);
 		yield return null;
  		
   	}
   }*/

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
