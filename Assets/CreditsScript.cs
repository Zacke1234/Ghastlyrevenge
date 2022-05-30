using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
public class CreditsScript : MonoBehaviour
{
    public Button backbutton;
    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        backbutton = root.Q<Button>("back-button");

        backbutton.clicked += backbuttonpressed;
    }

    void backbuttonpressed()
    {
        SceneManager.LoadScene("Menu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
