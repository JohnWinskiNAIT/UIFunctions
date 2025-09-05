using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ModifyText : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI myText;

    Color[] textColors = {Color.white, Color.red, Color.blue, Color.green};

    [SerializeField] Toggle boldToggle, italicToggle;

    [SerializeField] Slider sizeSlider;
    // Start is called before the first frame update
    void Start()
    {
        UpdateSlider();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExitApp()
    {
        Application.Quit();
    }

    public void ChangeSize(int size)
    {
        myText.fontSize = size;
        UpdateSlider();
    }

    public void ChangeSize(float size)
    {
        myText.fontSize = size;
    }

    void UpdateSlider()
    {
        sizeSlider.value = myText.fontSize;
    }

    public void ChangeColor(int index)
    {
        myText.color = textColors[index];
    }

    public void ToggleBold()
    {
        myText.fontStyle ^= FontStyles.Bold;
    }
    public void ToggleItalic()
    {
        myText.fontStyle ^= FontStyles.Italic;
    }

    public void ToggleUnderline()
    {
        myText.fontStyle ^= FontStyles.Underline;
    }

    public void ChangeText(string newText)
    {
        myText.text = newText;
    }
}
