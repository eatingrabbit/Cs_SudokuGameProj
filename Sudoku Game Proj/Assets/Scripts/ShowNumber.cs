using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowNumber : MonoBehaviour
{
    public TextMesh number1;
    public TextMesh number2;
    public TextMesh number3;
    public TextMesh number4;
    public TextMesh number5;
    public TextMesh number6;
    public TextMesh number7;
    public TextMesh number8;
    public TextMesh number9;

    public static ShowNumber instance;

    void Awake()
    {
        instance = this;
    }

    public void ShowNum()
    {
        number1.text = LevelGenerator.instance.ary[0, 0].ToString();
        number2.text = LevelGenerator.instance.ary[0, 1].ToString();
        number3.text = LevelGenerator.instance.ary[0, 2].ToString();
        number4.text = LevelGenerator.instance.ary[0, 3].ToString();
        number5.text = LevelGenerator.instance.ary[0, 4].ToString();
        number6.text = LevelGenerator.instance.ary[0, 5].ToString();
        number7.text = LevelGenerator.instance.ary[0, 6].ToString();
        number8.text = LevelGenerator.instance.ary[0, 7].ToString();
        number9.text = LevelGenerator.instance.ary[0, 8].ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
