using UnityEngine;
using UnityEngine.UIElements;

public class SimpleUIButton : MonoBehaviour
{
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        var button = root.Q<Button>("testButton");

        button.clicked += () =>
        {
            Debug.Log("UI Toolkit Button Clicked!");
        };
    }
}
