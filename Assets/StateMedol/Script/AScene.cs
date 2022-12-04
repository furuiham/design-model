using UnityEngine;

public class AScene : SceneStateBase {
    public AScene(SceneStateController stateController) : base(stateController) {
        this.sceneName = "A";
        Debug.Log("A");
    }

    public override void Start() {
        Debug.Log("in a");
    }
}