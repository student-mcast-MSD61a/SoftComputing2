using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameSave : MonoBehaviour
{

    public string userName;
    public GameObject inputField;

    public void saveName()
    {
        userName = inputField.GetComponent<Text>().text;

    }


}
