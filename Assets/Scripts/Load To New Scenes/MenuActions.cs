using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MenuActions : MonoBehaviour {
	public static string langSelected;

	public void MENU_ACTION_GotoPage(string sceneName)
	{
		//Application.LoadLevel(sceneName);
		SceneManager.LoadScene(sceneName);
	}

	public void MENU_ACTION_UnloadScene(string originSceneName)
	{
		//Application.LoadLevel(sceneName);
		SceneManager.UnloadSceneAsync(originSceneName);
	}

	public void resetScore()
	{
		Scene activeScene = SceneManager.GetActiveScene ();
		if (activeScene.name == "Level 1_Play") {
			ClickToDestroy.score = TimerCountdownL1Win.intial_score;
		}
		if (activeScene.name == "Level 2_Play") {
			ClickToDestroy.score = TimerCountdownL2Win.intial_score;
		}
		if (activeScene.name == "Level 3_Play") {
			ClickToDestroy.score = TimerCountdownL3Win.intial_score;
		}
		if (activeScene.name == "Level 4_Play") {
			ClickToDestroy.score = TimerCountdownL4Win.intial_score;
		}
	}

	public void setLanguage(){
		if (EventSystem.current.currentSelectedGameObject.name == "btn_VN") {
			langSelected = "VN";
			xmlReader_menu.currentLanguage = 1;
			xmlReader_HTP.currentLanguage = 1;
			xmlReader_Dict.currentLanguage = 1;
			xmlReader_Level_Intro_1.currentLanguage = 1;
			xmlReader_Level_Intro_2.currentLanguage = 1;
			xmlReader_Level_Intro_3.currentLanguage = 1;
			xmlReader_Level_Intro_4.currentLanguage = 1;
			xmlReader_Level_Intro_5.currentLanguage = 1;
			xmlReader_Level_Play_5.currentLanguage = 1;
		} else {
			langSelected = "EN";
			xmlReader_menu.currentLanguage = 0;
			xmlReader_HTP.currentLanguage = 0;
			xmlReader_Dict.currentLanguage = 0;
			xmlReader_Level_Intro_1.currentLanguage = 0;
			xmlReader_Level_Intro_2.currentLanguage = 0;
			xmlReader_Level_Intro_3.currentLanguage = 0;
			xmlReader_Level_Intro_4.currentLanguage = 0;
			xmlReader_Level_Intro_5.currentLanguage = 0;
			xmlReader_Level_Play_5.currentLanguage =0;

		}
	
	}



		
}
