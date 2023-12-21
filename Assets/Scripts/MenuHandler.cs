using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;
    public void StartGame()
    {
        DataManager.instance.userName = inputField.text;
        SceneManager.LoadScene(1);
    }
}
