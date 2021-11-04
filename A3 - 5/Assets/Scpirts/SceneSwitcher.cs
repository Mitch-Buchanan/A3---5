using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Start is called before the first frame update
    public void playGame (string sceneName) {
    	SceneManager.LoadScene(sceneName);
    }
}
