using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellorSpin : MonoBehaviour
{
    public int spinSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // rotate propellor
        transform.Rotate(0, 0, spinSpeed * Time.deltaTime);
    }
}
