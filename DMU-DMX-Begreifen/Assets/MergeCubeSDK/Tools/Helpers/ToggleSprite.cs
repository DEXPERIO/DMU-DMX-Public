﻿using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ToggleSprite : MonoBehaviour 
{
	public Sprite onSprite;
	public Sprite offSprite;
	public bool isOn;
	public void SetState(bool isOnTP){
		isOn = isOnTP;
		GetComponent<Image>().sprite = (isOn) ? onSprite : offSprite;
	}
	public void ToggleSpriteVisuals()
	{
		isOn = !isOn;
		GetComponent<Image>().sprite = (isOn) ? onSprite : offSprite;
	}
}
