
using UnityEngine;
using System.Collections;

public class grabberscript : MonoBehaviour
{
	Vector2 mousePos;
	public Camera cam;
	public Rigidbody2D rb;
	public bool grabbed;
	RaycastHit2D hit;
	public float distance = 1f;
	public Transform holdpoint;
	public float throwforce;
	public LayerMask notgrabbed;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	

	void Update()
	{
		mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

		if (Input.GetMouseButtonDown(1))
		{

			if (!grabbed)
			{
				Physics2D.queriesStartInColliders = false;
				Vector2 lookDir = mousePos - rb.position;
				hit = Physics2D.Raycast(transform.position, lookDir, distance);

				if (hit.collider != null && hit.collider.tag == "trash")
				{
					grabbed = true;

				}


				//grab
				} 
				
			else if (!Physics2D.OverlapPoint(holdpoint.position, notgrabbed))
				{
				grabbed = false;

				if (hit.collider.gameObject.GetComponent<Rigidbody2D>() != null)
				{
					Vector2 lookDir = mousePos - rb.position;
					hit.collider.gameObject.GetComponent<Rigidbody2D>().velocity = lookDir * throwforce;
				}


				//throw
			}


		}

		if (grabbed)
		{ 
			hit.collider.gameObject.transform.position = holdpoint.position;
			if (Input.GetMouseButtonDown(0))
			{
				grabbed = false;
			}
		}

	}
	
	void OnDrawGizmos()
	{
		Gizmos.color = Color.green;

		Gizmos.DrawLine(transform.position, transform.position + Vector3.right * transform.localScale.x * distance);
	}
}