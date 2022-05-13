using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DataManager : MonoBehaviour
{
    //===============================================================
    public void SaveString(string _name, string _data)
    {
        PlayerPrefs.SetString(_name, _data); 
    }

    public string GetSavedString(string _Filename)
    {
        return PlayerPrefs.GetString(_Filename);
    }

    //===============================================================
    public void SaveIndex(string _name, int _data)
    {
        PlayerPrefs.SetInt(_name, _data);
    }

    public int GetSavedIndex(string _Filename)
    {
        return PlayerPrefs.GetInt(_Filename);
    }

    //===============================================================
    public void SaveFloatingPoint(string _Name, float _data)
    {
        PlayerPrefs.SetFloat(_Name, _data);
    }

    public float GetSavedFloatingPoint(string _Filename)
    {
        return PlayerPrefs.GetFloat(_Filename);
    }

    //===============================================================
    public void SaveBool(string _name, bool _data)
    {
        int Tempo;

        if (_data)
        {
            Tempo = 1;
        }
        else
        {
            Tempo = 0;
        }

        PlayerPrefs.SetInt(_name, Tempo);
    }

    public bool GetSavedBool(string _Filename)
    {
        bool Tempo;
        int TempInt = PlayerPrefs.GetInt(_Filename);

        if (TempInt == 1)
        {
            Tempo = true;
        }
        else
        {
            Tempo = false;
        }

        return Tempo;
    }
}
