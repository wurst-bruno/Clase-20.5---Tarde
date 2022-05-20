using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class prefabcloner : MonoBehaviour
{


    public GameObject prefab;
    public Text inputCloneAmount;
    public Text displayClonesLeft;
    public InputField ifield;
    int counter;


    
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        displayClonesLeft.text = "?";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClonePrefab()
    {
        if (inputCloneAmount.text != "")
        {
            ifield.readOnly = true;
            int cloneamount = int.Parse(inputCloneAmount.text);
            if (counter < cloneamount)
            {
                Instantiate(prefab);
                counter++;
                displayClonesLeft.text = (int.Parse(inputCloneAmount.text) - counter).ToString();
            }
        }
        else
        {
            displayClonesLeft.text = "ERROR, INGRESÁ UN VALOR";
        }
    }



}
