using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassValues : MonoBehaviour {

    [SerializeField]
    public static int index_value;

    private void Start()
    {
        index_value = SceneManager.GetActiveScene().buildIndex + 1;
        Debug.Log("index_value = " + index_value);
    }

}
