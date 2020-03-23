using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    void Start()
    {
        //typ_zmiennej nazwa
        //deklaracja
        int a;
        //inicjalizacja
        a = 10;
        //2 w 1
        int b = 20;
        Debug.Log(a);

        { //skakanie
            Debug.Log(b);
        }

        { //chodzenie
            int c = 20;
        }

        float fa = 1.5f; //zmiennoprzecinkowa
        fa = 20.0f;
        bool logiczna = true; //false
        string str = "jeśli napis";

        Debug.Log("fa: " + fa + " logiczna: " + logiczna + " str: " + str);

        //operacje na zmiennych + - * /
        Debug.Log(a / b);
        Debug.Log(a / fa);
        Debug.Log(Mathf.Sqrt(2));

        //operacje logiczne
        Debug.Log(a == b);
        Debug.Log(a != b);
        Debug.Log(a > b);
        Debug.Log(a < b);
        Debug.Log(a >= b);
        Debug.Log(a <= b);

        //if (warunek_logiczny) { }

        if (a == b)
        {
            Debug.Log("Tak jest taka sama");
        }
        else if (a < b) ;
        {
            Debug.Log("a < b");
        }else
        {
            Debug.Log("Żadne z powyższych");
        }

        Koniunkcja(a, b);
        Alternatywa();
        
        
        public void Koniunkcja(int a, int b)
        {
            //koniunkcja
            Debug.Log((a != b) && (a > 0));

            if (a != b)
            {
                if (a > 0)
                {
                    //kod}
                }
            }

            if ((a != b) && (a > 0))
            {
                //kod
            }
        }

        public void Alternatywa()
        {
            //brzydka wersja
            int hp = 2, time = 1;
            bool amulet = true;

            if (hp <= 0)
            {
                if (!amulet)
                {//sprawdzamy czy amulet false  
                }
                else
                { }
            }



            //alternatywa - ładna wersja
            if (hp <= 0 || time <= 0)
            {
                if (!amulet)
                {//sprawdzamy czy amulet false  
                }
                else
                {

                }
            }
        }


    }
    void Update()
    {
        
    }
}
