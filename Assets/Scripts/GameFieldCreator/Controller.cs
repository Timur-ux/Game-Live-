using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FieldCreatorController : MonoBehaviour
{
    public FieldCreatorModel _model;

    public void onSubmit(string _width, string _height)
    {
        int width;
        int height;
        try
        {
            width = int.Parse(_width);
            height = int.Parse(_height);
        } catch(FormatException e)
        {
            Debug.LogError("Invalid option data: " + _width + " or " + _height);
            return;
        }

        if(width <= 0 || height <= 0)
        {
            Debug.LogError("Negative frame size, width: " + width + ", height: " + height);
            return;
        }

        _model.CreateGameFieldScene(width, height);
    }
}
