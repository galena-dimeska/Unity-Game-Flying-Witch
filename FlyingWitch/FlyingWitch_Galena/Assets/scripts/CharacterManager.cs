using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterManager : MonoBehaviour
{
    
    public CharacterDatabase cdb;
    public SpriteRenderer artworkSprite;
    private int selectedOption = 0;
    

    void Start()
    {
        if (!PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption=0;    
        }
        else
        {Load(); }

        UpdateCharacter(selectedOption);
    }

    public void NextOption()
    {
        selectedOption++;
        if(selectedOption >= cdb.CharacterCount)
        {selectedOption=0;}
        UpdateCharacter(selectedOption);
        Save();
    }

    public void BackOption()
    {
        selectedOption--;
        if(selectedOption <0)
        {selectedOption=cdb.CharacterCount-1;}
        UpdateCharacter(selectedOption);
        Save();
    }

    public void UpdateCharacter(int selectedOption)
    {
        character c=cdb.GetCharacter(selectedOption);
        artworkSprite.sprite=c.characterSprite;
    }

    private void Load()
    { 
        selectedOption=PlayerPrefs.GetInt("selectedOption");
    }

    private void Save()
    {
        PlayerPrefs.SetInt("selectedOption", selectedOption);
    }
    
    public void ChangeScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
