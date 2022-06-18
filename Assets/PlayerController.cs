using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 10;
    private float xVel = 0;
    private float yVel = 0;
    

    // Update is called once per frame
    void Update()
    {
        xVel = Input.GetAxis("Horizontal");
        yVel = Input.GetAxis("Vertical");

        Vector2 mVec = new Vector2(xVel,yVel);

        // ? lætur lengd vectors alltaf vera 1 en breytir ehv þannig movement verður frekar janky
        // mVec.Normalize();

        transform.Translate(mVec * Speed *  Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other) {
        Debug.Log("Collision");
    }
}
