using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeWallJump : MonoBehaviour
{
    public Transform playerPosition;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Player")
        {
            PlayerMovement.canWall = true;
            Destroy(gameObject);
        }
    }
}
