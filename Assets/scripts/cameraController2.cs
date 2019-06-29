using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController2 : MonoBehaviour {
	public Transform target;
	public float walkdistance;
	public float rundistance;
	public float height;
	private Transform _myTransform;
	// Use this for initialization
	void Start () {
		if(target==null)
		{
			Debug.LogWarning("no target");
		}
		_myTransform=target;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void LateUpdate(){
		_myTransform.position=new Vector3(target.position.x,target.position.y+height,target.position.z-walkdistance);
		
	}
}
