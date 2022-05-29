using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMetaData : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TimeOfDeath = 0;
        EnemiesKilled = 0;
        ChestsLooted = 0;

        Title = PlayerPrefs.GetString("Title", "Old King");
        WeaponName = PlayerPrefs.GetString("StartingWeapon", "Sword");
        Weapon = Weapon.GetWeaponByName(WeaponName);

        GetComponent<PlayerWeapons>().GainWeapon(Weapon);

        GetComponent<Health>().DeathSounds = (Title == "Grumpy Cat") ? DeathSounds_Grumpy : DeathSounds_Grumpy;
        GetComponent<Health>().HurtSounds = (Title == "Grumpy Cat") ? HurtSounds_Grumpy : HurtSounds_Grumpy;

        switch (Title)
        {
            case "Old King":
                spriteRenderer.sprite = Sprite_OldKing;
                break;
            case "Grumpy Cat":
                spriteRenderer.sprite = Sprite_Grumpy;
                break;
            case "Happy Cat":
                spriteRenderer.sprite = Sprite_Happy;
                break;
        }
    }

    static public string Title;
    static public string WeaponName;
    static public Weapon Weapon;

    public Sprite Sprite_OldKing;
    public Sprite Sprite_Grumpy;
    public Sprite Sprite_Happy;

    public AudioClip[] DeathSounds_Grumpy;
    public AudioClip[] DeathSounds_Happy;

    public AudioClip[] HurtSounds_Grumpy;
    public AudioClip[] HurtSounds_Happy;

    public SpriteRenderer spriteRenderer;

    public static int TimeOfDeath;
    public static int EnemiesKilled;
    public static int ChestsLooted;


    bool isQuitting = false;
    private void OnApplicationQuit()
    {
        isQuitting = true;
    }

    private void OnDestroy()
    {
        if (isQuitting)
            return;

        TimeOfDeath = Mathf.CeilToInt(TimeManager.Instance.ElapsedTime);
        PlayerPrefs.SetInt("Legacy Points", PlayerPrefs.GetInt("Legacy Points", 0) + TimeOfDeath);
        PlayerPrefs.SetInt("Total Legacy Points", PlayerPrefs.GetInt("Total Legacy Points", 0) + TimeOfDeath);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
