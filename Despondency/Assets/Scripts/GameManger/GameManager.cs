using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

[RequireComponent(typeof(DataManager))]
public class GameManager : MonoBehaviour
{
    [Header("General")]
    [Tooltip("What will be affected by the Quit Function.")]
    [SerializeField] UnityEvent m_OnExit;

    [Tooltip("Set if the GM Input will be used.")]
    [SerializeField] bool m_UseInput = false;

    //=================================================

    private void Update()
    {
        if (!m_UseInput)
            return;

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Quit();
        }
    }

    public void ChangeLevel(string _name)
    {
        SceneManager.LoadScene(_name);
    }

    public void Quit()
    {
        m_OnExit.Invoke();
        Application.Quit();
    }
}
