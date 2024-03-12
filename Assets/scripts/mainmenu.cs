using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Loading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainmenu : MonoBehaviour
{
    public static string input;
    [SerializeField] private TMP_InputField input_field;
    [SerializeField] private Button play_button;
    [SerializeField] private TMP_Text input_text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //getting the reading the input name
    public void ReadInputName(string user_name)
    {
        input = user_name;
        input_field.gameObject.SetActive(false);
        input_text.text = "Hello " + input;
        play_button.gameObject.SetActive(true);
        
    }

    
    //loading the scean
    public void PlayGame()
    {
        
        SceneManager.LoadSceneAsync(1);
     }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
