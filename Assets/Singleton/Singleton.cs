using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Singleton {
    private static Singleton _instance;

    public static Singleton Instance {
        get {
            if (_instance == null) {
                _instance = new Singleton();
            }

            return _instance;
        }
    }

    private Singleton() { }
}

public class CountClass {
    private static int count;

    public CountClass() {
        count++;
        Debug.Log(count);
        if (count > 2) {
            Debug.LogError("ERROR");
        }
    }
}