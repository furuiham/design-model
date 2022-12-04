using UnityEngine;

public class CScene : SceneStateBase {

    public CScene(SceneStateController stateController) : base(stateController) {
        this.sceneName = "C";
        Debug.Log("C");
    }

    public override void Start() {
        base.Start();
        Debug.Log("in c");
    }
}