using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    //새로운 변수 접근 방식
    public bool PlayerDie = false;
    public float playTimeCurrent = 99999999999999f;
    public float playTimeMax = 99999999999999f;
    static DataManager instance;

    public static DataManager Instance
    {
        get
        {
            return instance;
        }
    }
    private void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            DestroyObject(gameObject);
        }
    }
}
