using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class PlayerNetwork : NetworkBehaviour
{
    private Vector3 change;
    private float moveSpeed = 5;


    private void Update()
    {
        if (!IsOwner) return;
        if (Input.GetKeyDown(KeyCode.LeftArrow)) change.x = -1;
        if (Input.GetKeyDown(KeyCode.RightArrow)) change.x = 1;
        if (Input.GetKeyDown(KeyCode.UpArrow)) change.y = 1;
        if (Input.GetKeyDown(KeyCode.DownArrow)) change.y = -1;
        transform.position += change * moveSpeed * Time.deltaTime;
    }
}
