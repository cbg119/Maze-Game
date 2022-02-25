using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBounce : MonoBehaviour
{
    public float rotateChange;
    public float bounceSpeed;
    public float maxBounceHeight;
    private Vector3 initialPos;
    private int goingUp;
    //private Vector3 vecTest;


    // Start is called before the first frame update
    void Start()
    {
        initialPos = transform.position;
        bounceSpeed = (transform.position.y + bounceSpeed > transform.position.y + maxBounceHeight) ? maxBounceHeight / 100 : bounceSpeed;
    }

    // Update is called once per frame
    void Update()
    {
    

        transform.Rotate(0, rotateChange, 0);
        
        if (transform.position.y <= initialPos.y) {
            goingUp = 1;
        }
        else if (transform.position.y >= initialPos.y + maxBounceHeight) {
            goingUp = -1;
        }
        
        transform.position += new Vector3(0, bounceSpeed * goingUp, 0);

    }
}
