using System.Collections;
using System.Collections.Generic;
using UnityEngine.UIElements;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public bool follow = false;
    public float moveSpeed = 10;
    public float maxSpeed = 10;
    public int rotationOffset = 0;
    public GameObject player;

    void Update()
    {
        // ? lætur músina stjórna frekar en 
        // if (Input.GetMouseButtonDown(0)) mouseDown = true;
        // if (mouseDown && Input.GetMouseButtonUp(0)) mouseDown = false;

        if (follow) transform.Translate(new Vector2(1, 0) * moveSpeed * Time.deltaTime);
        //Move the object to XYZ coordinates defined as horizontalInput, 0, and verticalInput respectively.

        float dist = Vector2.Distance(player.transform.position, transform.position);
        if (rotationOffset < 90 && dist <= 2.5) rotationOffset += 10;
        else if (rotationOffset > 0 && dist > 2.5) rotationOffset -= 10;


        // Vector3 difference = Camera.main.ScreenToWorldPoint(player.transform.position) - transform.position;
        Vector3 difference = player.transform.position - transform.position;
        if (System.Math.Abs(difference.x) < 0.5f && System.Math.Abs(difference.y) < 0.5f)
        {
            if (moveSpeed > 0) moveSpeed--;
        }
        else if (moveSpeed < maxSpeed) moveSpeed++;
        difference.Normalize();
        float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotation_z + rotationOffset);
    }
}
