using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
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

    public void UpdateCharacter(int selectedOption)
    {
        character c=cdb.GetCharacter(selectedOption);
        artworkSprite.sprite=c.characterSprite;
    }

    private void Load()
    { 
        selectedOption=PlayerPrefs.GetInt("selectedOption");
    }

}
