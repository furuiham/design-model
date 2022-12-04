using System;
using UnityEngine;

public class GameLoop : MonoBehaviour{
    private SceneStateController controller;

    private void Awake() {
        controller = new SceneStateController();
        GameObject.DontDestroyOnLoad(this.gameObject);
    }

    private void Start() {
        controller.SetState(new SceneStateBase(controller));
    }

    private void Update() {
        controller.StartUpdate();

        if (Input.GetKeyDown(KeyCode.A)) {
            controller.SetState(new AScene(controller));
        }

        if (Input.GetKeyDown(KeyCode.B)) {
            controller.SetState(new BScene(controller));
        }

        if (Input.GetKeyDown(KeyCode.C)) {
            controller.SetState(new CScene(controller));
        }
    }
}