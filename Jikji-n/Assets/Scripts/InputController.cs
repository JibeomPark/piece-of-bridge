using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] private GameObject worldObject;
    [SerializeField] private GameObject player;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;

    private Vector2 moveDir = new Vector2(1, 0);
    private bool isMoving = false;
    private bool isJumping = false;

    private Transform worldRB;
    private Rigidbody2D playerRB;

    private void Awake()
    {
        worldRB = worldObject.GetComponent<Transform>();
        playerRB = player.GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        GroundPosCheck();

        if ((isMoving || isJumping) == false)
            return;

        if (isMoving)
        {
            Vector3 moveOffset = moveDir * (moveSpeed * Time.fixedDeltaTime);
            worldRB.position = worldRB.position + moveOffset;
        }

        if (isJumping)
        {
            playerRB.AddForce(new Vector3(0f, jumpForce, 0f), ForceMode2D.Impulse);
            isJumping = false;
        }
    }


    void Update()
    {
        if(Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            isMoving = false;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            moveDir = new Vector2(1, 0);
            isMoving = true;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            moveDir = new Vector2(-1, 0);
            isMoving = true;
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && isJumping == false)
        {
            isJumping = true;
        }
    }

    private void GroundPosCheck()
    {
        if(worldObject.transform.localPosition.x <= -1920.0f ||
            worldObject.transform.localPosition.x > 0)
        {
            ResetWorldPos();
        }
    }

    private void ResetWorldPos()
    {
        worldObject.transform.position = Vector3.zero;
    }
}
