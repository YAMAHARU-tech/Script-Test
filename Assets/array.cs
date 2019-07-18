using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] point = { 50, 90, 100, 281, 96 };

            for (int i = 0; i < point.Length; i++)
        {
            Debug.Log(point[i]);
        }

            for(int j = point.Length - 1; 0 <= j; j--)
        {
            Debug.Log(point[j]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
