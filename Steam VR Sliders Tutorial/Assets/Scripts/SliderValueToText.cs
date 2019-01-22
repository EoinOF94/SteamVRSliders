using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValueToText : MonoBehaviour {

    public Slider sliderUI;
    private Text textSliderValue;

    // Use this for initialization
    void Start () {

        //Get the components which the script is attached to, in this case a Slider
        textSliderValue = GetComponent<Text>();
        ShowSliderValue();

    }
	
	// Update is called once per frame
	void Update () {

    }

    //This function takes the slider value and gives it to the text field
    public void ShowSliderValue()
    {

        //Convert the type of the slider from float to string and save in the slidermessage variable
        string sliderMessage = "Slider Value = " + sliderUI.value;
        textSliderValue.text = sliderMessage;
    }

}
