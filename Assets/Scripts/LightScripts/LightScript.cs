using UnityEngine;
using System.Collections;

public class LightScript : MonoBehaviour 
{
	public float amplitude = 0.2F;  
	public Light  lt;
    // Use this for initialization
	void Start () {		
		amplitude = 0.2F;
		lt = GetComponent <Light>();    
	}
	
	// Update is called once per frame
	void Update () 
    {              
        lt.intensity = amplitude;

        if (Input.GetKey(KeyCode.L))
        {   
             amplitude = 1F; 
            
        }  
        if(Input.GetKey(KeyCode.O))
        {  
           
             amplitude = 0.2F;
        } 

     }
} 