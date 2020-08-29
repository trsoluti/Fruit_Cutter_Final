using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    // Randomly generate the rotate degree of the fruit
    int rotateDegree;

    // Start is called before the first frame update
    void Start()
    {
        rotateDegree = Random.Range(-6, 6);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotateDegree);

        // Delete the fruit when it is falling down
        // y position is less than -10
        if (transform.position.y < -10)
        {
            Destroy(transform.gameObject);
        }
    }
}
