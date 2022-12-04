using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BScene : SceneStateBase {
    public BScene(SceneStateController stateController) : base(stateController) {
        this.sceneName = "B";
        Debug.Log("B");
    }

    public override void Start() {
        base.Start();
        Debug.Log("in b");
    }
}
