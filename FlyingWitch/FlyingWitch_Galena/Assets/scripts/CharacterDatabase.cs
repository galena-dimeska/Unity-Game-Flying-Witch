using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CharacterDatabase : ScriptableObject
{
    public character[] c;

    public int CharacterCount
    {
        get {return c.Length;}
    }

    public character GetCharacter(int index)
    {
        return c[index];
    }
}
