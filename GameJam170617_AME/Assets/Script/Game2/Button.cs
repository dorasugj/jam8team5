﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	public void GoRetry()
	{
		SceneManager.LoadScene("Scene/GameScene2");
	}

	public void GoTitle()
	{
        SceneManager.LoadScene("TitleScene");
	}
}
