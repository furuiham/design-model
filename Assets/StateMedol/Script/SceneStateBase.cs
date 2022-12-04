using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class SceneStateBase {
    public string sceneName;
    public SceneStateController stateController;

    public SceneStateBase(SceneStateController stateController) {
        stateController = this.stateController;
    }

    public virtual void Start() {

    }

    public virtual void Update() {

    }

    public virtual void Stop() {

    }

    public override string ToString() {
        return sceneName;
    }
}
