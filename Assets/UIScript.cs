using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIScript : MonoBehaviour
{
   
    public Label label;
    public Label labelhealth;
    public Label ghastlyenergy;
    public PlayerScript2 Playerscript2;
    // Start is called before the first frame update
    void Start()
    {
        
        var root = GetComponent<UIDocument>().rootVisualElement;

        label = root.Q<Label>("Label");

        labelhealth = root.Q<Label>("Health");

        ghastlyenergy = root.Q<Label>("GhastlyEnergy");

        




    }

    // Update is called once per frame
    void Update()
    {
        labelhealth.text = PlayerScript2.health + "/" + "100";

        ghastlyenergy.text = PlayerScript2.GhastlyEnergy + "/" + "100";
        if (PlayerScript2.Alive == true)
        {
            label.text = "Alive";
        }
        if (PlayerScript2.Alive == false)
        {
            label.text = "Dead";
        }
    }
}
