using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScreen : MonoBehaviour {
    public void LoadLevel(string sceneName, GameObject loadingScreen, Slider slider)
    {
        StartCoroutine(LoadAsynchronously(sceneName, loadingScreen, slider));
    }
IEnumerator LoadAsynchronously(string sceneName, GameObject loadingScreen, Slider slider)
    {
        loadingScreen.SetActive(true);
        yield return new WaitForSeconds(5);
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);
        while (!operation.isDone)
        {
            
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            yield return null;
        }
    }
}
