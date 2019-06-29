using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
	public int n;
	public Animator animator;
	public Rigidbody rbody;
	private float inputH;
	private float inputV;
	private bool run;
	// Use this for initialization
	void Start () 
	{
		animator= GetComponent<Animator>();
		rbody=GetComponent<Rigidbody>();
		n=0;
		run=false;
	}
	
	// Update is called once per frame
	void Update () 
	{
			if(Input.GetKeyDown("1"))
			{
				animator.Play("WAIT01",-1,0f);
			}
			if(Input.GetKeyDown("2"))
			{
				animator.Play("WAIT02",-1,0f);
			}
			if(Input.GetKeyDown("3"))
			{
				animator.Play("WAIT03",-1,0f);
			}
			if(Input.GetKeyDown("4"))
			{
				animator.Play("WAIT04",-1,0f);
			}
			
			if(Input.GetMouseButtonDown(0))
			{
				//int n=Random.Range(0,2);
				if(n<4)
				{
					animator.Play("DAMAGED00",-1,0f);
					n++;
				}
				else
				{
					animator.Play("DAMAGED01",-1,0f);
					n=0;
				}
			}
			if(Input.GetKey(KeyCode.LeftShift))
			{
				run=true;
				
			}
			else
			{
				run=false;
			}
			if(Input.GetKey(KeyCode.Space))
			{
				animator.SetBool("jump",true);
			}
			else
			{
				animator.SetBool("jump",false);
			}
			inputH=Input.GetAxis("Horizontal");
			inputV=Input.GetAxis("Vertical");
			animator.SetFloat("inputH",inputH);
			animator.SetFloat("inputV",inputV);
			animator.SetBool("run",run);
		
			float moveX;
			
			float moveZ;
			moveZ=-1f*inputV*50f*Time.deltaTime;
			if(inputV<=0)
			{
				moveX=0f;
			}
			else
			{
				moveX=-1f*inputH*30f*Time.deltaTime;
			}
			if(moveZ>0f)
			{
				moveX=0f;
			}
			else if(run)
			{
				moveX*=3f;
				moveZ*=3f;
			}
			rbody.velocity= new Vector3(moveX,0f,moveZ);
	}
}
