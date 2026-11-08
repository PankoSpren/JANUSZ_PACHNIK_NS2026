using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{

    //Ta referencja jest pusta, zostaje uzupełniona podczas pierwszego HIT()
    private Rigidbody2D rb;

    public SpriteRenderer sprite;
    public Gradient hpColor;

    public float hp = 100; 

    private void Update()
    {
        //ttuaj było hp
    }

    //Funkcja wywoływana przy trafieniu
    public void Hit(float dmg)
    {
        if (rb == null && hp == 100) // &&
        {
            //if first hit activate rigidbody
            rb = GetComponent<Rigidbody2D>(); // skąd ten rigid body?
            rb.bodyType = RigidbodyType2D.Dynamic;
        }

        hp = hp - dmg; // -

        sprite.color = hpColor.Evaluate(hp / 100); 

        CheckIfKill();
    }

    //Jeśli życie spadnie poniżej zera obiekt powinien zostać zniszczony
    void CheckIfKill()
    {
        if (hp <= 0) // <=
        {
            Destroy(gameObject);
        }
    }

    // Funkcja zwraca największego inta z listy
    public int ReturnHighNumber(List<int> data)
    {
        // tutaj
        int high = 0;

        foreach (int i in data)
        {
            if (i > high)
            {
                high = i; // tutaj
            } 
        }

        return high; 
    }

  
}
