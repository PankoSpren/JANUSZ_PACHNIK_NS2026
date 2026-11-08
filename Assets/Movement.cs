using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]private GameObject playerCube;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) {movePlayer(new Vector3(0, 1, 0));}
        else if (Input.GetKeyDown(KeyCode.S)) {movePlayer(-new Vector3(0, 1, 0));}
        else if (Input.GetKeyDown(KeyCode.A)) {movePlayer(-new Vector3(1, 0, 0));}
        else if (Input.GetKeyDown(KeyCode.D)) {movePlayer(new Vector3(1, 0, 0));}
    }
    void movePlayer(Vector3 direction)
    {
        playerCube.transform.position += direction;
    }
}
