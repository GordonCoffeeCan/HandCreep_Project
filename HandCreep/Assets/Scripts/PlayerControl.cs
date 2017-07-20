using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    static public PlayerControl instance;

    public CapsuleCollider2D playerController;

    [SerializeField] private float moveSpeed = 5;
    [SerializeField] private float jumpSpeed = 8;

    private string ctrHorizontal;
    private string ctrVeritcal;
    private string ctrJump;
    private string ctrHook;

    private bool isGround;

    private Rigidbody2D rig;
    
    private void Awake() {
        instance = this;
        rig = this.GetComponent<Rigidbody2D>();
        playerController = this.GetComponent<CapsuleCollider2D>();
        
    }

    // Use this for initialization
    void Start () {
        switch (this.tag) {
            case "Player_1":
                ctrHorizontal = "Player_1_H";
                ctrVeritcal = "Player_1_V";
                ctrJump = "Player_1_Jump";
                break;
            case "Player_2":
                ctrHorizontal = "Player_2_H";
                ctrVeritcal = "Player_2_V";
                ctrJump = "Player_2_Jump";
                break;
        }
    }
	
	// Update is called once per frame
	void Update () {
        rig.velocity = new Vector2(Input.GetAxis(ctrHorizontal) * moveSpeed * Time.deltaTime * 10, rig.velocity.y);
    }

    private void FixedUpdate() {
        
    }
}
