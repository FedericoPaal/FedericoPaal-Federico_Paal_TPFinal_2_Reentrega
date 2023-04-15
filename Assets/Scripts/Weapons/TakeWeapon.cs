using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeWeapon : MonoBehaviour
{
    public GameObject[] weapons;

    public void WeaponToActivate(int num)
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            weapons[i].SetActive(false);
        }

        weapons[num].SetActive(true);
    }


 
        class MyWeapons
    {
        static void WeaponsDMG(string[] strings, int num)
        {
            Dictionary<string, int> WeaponDamage = new Dictionary<string, int>();

            WeaponDamage.Add("Pistol", 10);
            WeaponDamage.Add("Revolver", 10);

            Console.WriteLine(WeaponDamage["Pistol"]);

            Console.Read();
        }
    }
}
