using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Get the current mouse position
        Vector3 mousepos = new Vector3(
            Input.mousePosition.x,
            Input.mousePosition.y,
            1
            );
        Vector3 knifepos = Camera.main.ScreenToWorldPoint(mousepos);

        transform.position = knifepos;
    }
}
