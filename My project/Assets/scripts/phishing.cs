using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phishing : MonoBehaviour

{
    public static phishing instance;
    public GameObject Fisher;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance != null){
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
