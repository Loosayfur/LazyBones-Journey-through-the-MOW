using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadInput : MonoBehaviour
{
    public string input;
    private Player player;
    private InputField inputField;
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        ReadInputString(input);
        if (player.Name == null)
        {
            inputField.text = player.Name;
        }
    }

    public void ReadInputString(string s)
    {
        input = s;
    }

}
