using UnityEngine;
using System.Collections;

public class HandRayCastScript : MonoBehaviour {
    public float leftrayDist = 0.01f;
    /*public float rightrayDist = 0.01f;
    public float uprayDist = 0.01f;
    public float downrayDist = 0.01f;
    public Rigidbody2D Hand;*/

    private RaycastHit2D leftHit;
    private RaycastHit2D rightHit;
    private RaycastHit2D upHit;
    private RaycastHit2D downHit;

    void Start() {
        //Hand = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate() {
        leftHit = Physics2D.Raycast(new Vector2(this.transform.position.x - PlayerControl.instance.playerController.size.x / 2, this.transform.position.y), Vector2.left, leftrayDist);
        rightHit = Physics2D.Raycast(new Vector2(this.transform.position.x + PlayerControl.instance.playerController.size.x / 2, this.transform.position.y), Vector2.right, leftrayDist);
        upHit = Physics2D.Raycast(new Vector2(this.transform.position.x, this.transform.position.y + PlayerControl.instance.playerController.size.y / 2), Vector2.up, leftrayDist);
        downHit = Physics2D.Raycast(new Vector2(this.transform.position.x, this.transform.position.y - PlayerControl.instance.playerController.size.y / 2), Vector2.down, leftrayDist);
        if (leftHit.collider != null) {
            if (leftHit.collider.gameObject.tag == "Wall") {
                Debug.Log("wall hit");
            }
            
        }
        if (rightHit.collider != null) {
            if (rightHit.collider.gameObject.tag == "Wall") {
                Debug.Log("wall hit");
            }
        }
		if (upHit.collider != null) {
            if (upHit.collider.gameObject.tag == "Wall") {
                Debug.Log("wall hit");
            }
        }
        if (downHit.collider != null) {
            if (downHit.collider.gameObject.tag == "Ground") {
                Debug.Log("on the ground");
            }
        }
    }

    void Update() {
        Debug.DrawRay(this.transform.position, Vector2.left, Color.blue);
        Debug.DrawRay(this.transform.position, Vector2.right, Color.yellow);
        Debug.DrawRay(this.transform.position, Vector2.up, Color.red);
        Debug.DrawRay(this.transform.position, Vector2.down, Color.white);
    }
}