using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
        var instance = Singleton.Instance;
        Debug.Log(instance.ToString());
        Debug.Log(instance.Equals(Singleton.Instance));

        CountClass a = new CountClass();
        CountClass b = new CountClass();
        CountClass c = new CountClass();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
