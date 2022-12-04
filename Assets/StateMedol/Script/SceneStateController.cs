using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStateController {
    public SceneStateBase state;
    public bool isStateChange = false;

    public void SetState(SceneStateBase sceneStateBase) {
        if (state != null) {
            state.Stop();
        }

        isStateChange = true;
        LoadScene(sceneStateBase.sceneName);
        state = sceneStateBase;
    }

    public void LoadScene(string sceneName) {
        if (sceneName == default || sceneName.Length == 0) {
            return;
        }

        SceneManager.LoadScene(sceneName);
    }

    public void StartUpdate() {
        if (state == null) {
            return;
        }

        if (isStateChange) {
            state.Start();
        }

        state.Update();
    }
}
