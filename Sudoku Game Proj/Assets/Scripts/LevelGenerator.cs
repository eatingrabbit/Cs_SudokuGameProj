using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    
    public int[,] ary = new int[9, 9] {{ 1,2,3,4,5,6,7,8,9 },
                                { 4,5,6,7,8,9,1,2,3 },
                                { 7,8,9,1,2,3,4,5,6 },
                                { 2,3,4,5,6,7,8,9,1 },
                                { 5,6,7,8,9,1,2,3,4 },
                                { 8,9,1,2,3,4,5,6,7 },
                                { 3,4,5,6,7,8,9,1,2 },
                                { 6,7,8,9,1,2,3,4,5 },
                                { 9,1,2,3,4,5,6,7,8 }};

    public static LevelGenerator instance;

    void Awake() { instance = this; }

    void Start()
    {
        ShowNumber.instance.ShowNum();

    }

}
