using UnityEngine;
using System.Collections;

public class HandRayCastScript : MonoBehaviour {
	public float leftraydist;
	public float rightraydist;
	public float upraydist;
	public Rigidbody2D Hand;
	void Start() {
		Hand = GetComponent<Rigidbody2D>();
	}
	void FixedUpdate() {
		RaycastHit2D lefthit = Physics2D.Raycast (transform.position, Vector2.left, leftraydist, LayerMask.NameToLayer ("HandSurface"));
		RaycastHit2D righthit = Physics2D.Raycast (transform.position, Vector2.right, rightraydist, LayerMask.NameToLayer ("HandSurface"));
		RaycastHit2D uphit = Physics2D.Raycast (transform.position, Vector2.up, upraydist, LayerMask.NameToLayer ("HandSurface"));
		if (lefthit.collider != null) {
			Debug.Log ("test");
			if (lefthit.collider.gameObject.tag == "Wall") {
				Debug.Log ("wall hit");
			}
		}
		if (righthit.collider.gameObject.tag == "Wall") {
			Debug.Log ("wall hit");
		}
		if (uphit.collider.gameObject.tag == "Wall") {
			Debug.Log ("wall hit");
		}
	}
		void Update(){
		{
			Debug.DrawRay(transform.position, Vector2.left * leftraydist, Color.green);
		}
		{
			Debug.DrawRay(transform.position, Vector2.right * rightraydist, Color.red);
		}
		{
			Debug.DrawRay(transform.position, Vector2.up * upraydist, Color.yellow);
		}
}
}