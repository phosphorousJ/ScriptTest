using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 10, 76, 32, 89, 265 };

        //配列の各要素を順番に表示
        for (int i = 0; i < array.Length; i++) 
        {
            Debug.Log(array[i]);
        }

        //配列の各要素を逆順に表示
        for (int j = 4; j >= 0 ; j--) 
        {
            Debug.Log(array[j]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
