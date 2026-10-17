using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cwiczenie : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<int> dane = new List<int> {1, 2, 3, 2, 1, 2, 1, 2, 2};
        List<int> jedynki = new List<int>();
        List<int> dwojki = new List<int>();
        List<int> trojki = new List<int>();

        for (int i = 0; i < dane.Count; i++)
        {
            if (dane[i] == 1)
            {
                jedynki.Add(dane[i]);
            }
            else if (dane[i] == 2)
            {
                dwojki.Add(dane[i]);
            }
            else if (dane[i] == 3)
            {
                trojki.Add(dane[i]);
            }   
        }
        dane.Clear();

        Debug.Log(dane.Count);
        Debug.Log(jedynki.Count);
        Debug.Log(dwojki.Count);
        Debug.Log(trojki.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
