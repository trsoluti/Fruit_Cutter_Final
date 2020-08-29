using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitThrower : MonoBehaviour
{
    public GameObject fruit;

    // Create a variable Timer - Data type Integer
    int timer = 0;

    // Update is called once per frame
    void Update()
    {
        // Increase the timer every frame
        timer = timer + 1;

        if (timer > 100)
        {
            transform.position = new Vector3(
                Random.Range(-10, 10),
                -8,
                0
                );

            // Clone the new fruit from existing fruit prefab
            // at the fruit thrower position
            GameObject newFruit = Instantiate(
                fruit,
                transform.position,
                transform.rotation
                );
            newFruit.GetComponent<Rigidbody2D>().AddForce(
                Vector3.up * 800
                );

            // Add the side force (left or right) to the new fruit
            // for swing when throwing upwards
            newFruit.GetComponent<Rigidbody2D>().AddForce(
                Vector3.left * Random.Range(-400, 400)
                );
            timer = 0;
        }
    }
}
