using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    //���ο� ���� ���� ���
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
