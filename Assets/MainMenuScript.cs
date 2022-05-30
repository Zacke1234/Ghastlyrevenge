using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
public class MainMenuScript : MonoBehaviour
{
    public Button button;
    public Button quitgamebutton;
    public Button creditsbutton;
    public PlayerScript2 playerscript;
    
    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        button = root.Q<Button>("start-button");
        quitgamebutton = root.Q<Button>("quit-button");
        creditsbutton = root.Q<Button>("credits-button");

        button.clicked += StartButtonPressed;
        quitgamebutton.clicked += quitbuttonpressed;
        creditsbutton.clicked += creditsbuttonpressed;
    }

    void StartButtonPressed()
    {
        SceneManager.LoadScene("Game");
        PlayerScript2.GhastlyEnergy = 50;
        PlayerScript2.health = 100;
    }

    void quitbuttonpressed()
    {

    }

    void creditsbuttonpressed()
    {
        SceneManager.LoadScene("Credits");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
