using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning_Spawn : MonoBehaviour
{
	public Lightning lightning;

	private GameObject source;

	private Vector3 sourcePosition;
    // Start is called before the first frame update
   IEnumerator Start(){
   //	source = GameObject.Find("LightningSource");  // set the source of the lightning to the source object
  //      sourcePosition= source.transform.position;
   	while(true){
   		Instantiate(lightning,sourcePosition,Quaternion.identity);
  	//	Instantiate(lightning,sourcePosition,Quaternion.identity);
 	//	Instantiate(lightning,sourcePosition,Quaternion.identity);
 		yield return null;
  		
   	}
   }
}
