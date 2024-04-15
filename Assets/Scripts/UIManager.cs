using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button Optionbutton;
    public GameObject OptionPanel;
    public bool optionbuttontogel = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        OptionPanel.SetActive(optionbuttontogel);
    }
    public void OptionButton()
    {
        optionbuttontogel = !optionbuttontogel;
    }
    public void SceneChange(int SceneChangeIndex)
    {
        SceneManager.LoadScene(SceneChangeIndex);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
