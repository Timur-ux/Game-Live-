using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class FieldCreatorView : MonoBehaviour
{
    public TMP_InputField _width;
    public TMP_InputField _height;
    public FieldCreatorController _controller;
    public void onSubmit()
    {
        string width = _width.text;
        string height = _height.text;

        _controller.onSubmit(width, height);
    }
}
