using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public float camSpeed = 15;
    private int xVel = 0;
    private int yVel = 0;

    // Update is called once per frame
    void Update () {
        Vector3 difference = player.transform.position - transform.position;
        if (difference.x > 1) xVel = 1;
        else if (difference.x < -1) xVel = -1;
        else xVel = 0;

        if (difference.y > 1) yVel = 1;
        else if (difference.y < -1) yVel = -1;
        else yVel = 0;

        transform.Translate(new Vector3(xVel,yVel) * camSpeed * Time.deltaTime);
    }
}