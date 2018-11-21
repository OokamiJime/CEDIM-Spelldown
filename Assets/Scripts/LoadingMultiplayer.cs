using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingMultiplayer : MonoBehaviour
{

    public string sceneName;
    public GameObject loadingScreen;
    public Slider slider;

    public string levelToLoad;
    public float aditionalWaitTime;

    public void LoadScene()
    {
        loadingScreen.SetActive(true);
        StartCoroutine(LoadAsync());
    }

    IEnumerator LoadAsync()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(levelToLoad);
        asyncLoad.allowSceneActivation = false;
        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            float progress = Mathf.Clamp01(asyncLoad.progress / .9f);
            slider.value = progress;

            yield return new WaitForEndOfFrame();
            if (asyncLoad.progress >= .9f)
            {
                yield return new WaitForSeconds(aditionalWaitTime);
                asyncLoad.allowSceneActivation = true;
            }
        }
    }
   
    
    }
