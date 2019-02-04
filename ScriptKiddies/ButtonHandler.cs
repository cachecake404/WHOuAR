using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


	

public class ButtonHandler : MonoBehaviour {
	
	public void On_Click_Login(){

		SceneManager.LoadScene("login");
	}
	public void On_Click_Stats(){

		SceneManager.LoadScene("stats");
	}
	public void On_Click_Badges(){

		SceneManager.LoadScene("badges");
	}
	public void On_Click_Scan(){

		SceneManager.LoadScene("scan");
	}
	public void On_Click_Exit(){
		 Application.Quit();
	}
	public void On_Click_Back(){

		if(PlayerPrefs.GetInt("islogged")==1)
			SceneManager.LoadScene("Main Menu");
		else
			SceneManager.LoadScene("Sign Page");
	}
	public void On_Click_Log_Out(){

		PlayerPrefs.SetInt("islogged", 0); 
		SceneManager.LoadScene("Sign Page");
	}
	public void On_Click_Scan_Sign(){

		SceneManager.LoadScene("scan_sign");
	}
	public void On_Click_Successful_Login(){
		PlayerPrefs.SetInt("islogged", 1);
		SceneManager.LoadScene("Main Menu");
	}
}
