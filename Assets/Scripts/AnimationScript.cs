﻿using UnityEngine;
using System.Collections;
using System.Reflection.Emit;

public class AnimationScript : MonoBehaviour
{
	private PlayerController playerr;
	private MenuController Menu_Control;
	// Use this for initialization
	void Start()
	{
		playerr = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
		Menu_Control = GameObject.Find("EventSystem").GetComponent<MenuController>();
	}
	
	// Update is called once per frame
	void Update()
	{
	
	}

	public void AfterAchievement()
	{
		playerr.CanInvoke = true;
		playerr.SymbolsGenerator();
	}

	public void PlayButton()
	{
		Menu_Control.CallWaitAndDo(0);
	}

	public void RestartButton()
	{
		Menu_Control.CallWaitAndDo(1);
	}

	public void AfterVideoAd()
	{
		
	}
}
