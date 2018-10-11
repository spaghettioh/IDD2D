using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{

    public FloatVariable HealthVariable;
    private string Health;
    public Text CurrentHealth;

    public FloatVariable ArmorVariable;
    private string Armor;
    public Text CurrentArmor;

    public string Weapon = "pistol";
    public Text CurrentWeapon;

    // Use this for initialization
    void Start ()
    {

    }

    // Update is called once per frame
    void Update ()
    {
        CurrentHealth.text = HealthVariable.Value.ToString();
        CurrentArmor.text = ArmorVariable.Value.ToString();
        CurrentWeapon.text = Weapon;
    }
}
