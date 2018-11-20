using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;



public class LoadingScreen : MonoBehaviour {
    public GameObject loadingScreen;
    public Slider slider;
    public VideoPlayer cutscene;
    public string sceneName;
    bool isLoading;
    

    public void Start()
    {
        cutscene.loopPointReached += EndReached;

    }

    private void EndReached(VideoPlayer source)
    {
        cutscene.gameObject.SetActive(false);
        Loadlevel(sceneName);
    }

  
    public void Loadlevel (string sceneName)
    {
        StartCoroutine(LoadAsynchronously(sceneName));
    }

    IEnumerator LoadAsynchronously(string sceneName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);

        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;

            yield return null;
        }
    }

	
}
