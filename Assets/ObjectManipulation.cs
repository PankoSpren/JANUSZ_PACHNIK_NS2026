using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectManipulation : MonoBehaviour
{
    public List<GameObject> gameObjects = new List<GameObject>();
    // Start is called before the first frame update
    [SerializeField] private Gradient gradient = new Gradient();
    void Start()
    {
        gameObjects.Add(GameObject.Find("ManipulateCubeOne"));
        gameObjects.Add(GameObject.Find("ManipulateCubeTwo"));
        gameObjects.Add(GameObject.Find("ManipulateSpriteOne"));
        gameObjects.Add(GameObject.Find("ManipulateSpriteTwo"));
        gameObjects.Add(GameObject.Find("ManipulateSpriteThree"));
        Dimension();
    
    }

    // Update is called once per frame
    void Update()
    {

        foreach (GameObject element in gameObjects)
        {
            if (element.GetComponent<MeshRenderer>() != null)
            {
                RotateCube(element.transform);
            }

            else if (element.GetComponent<SpriteRenderer>() != null)
            {
                SpriteGradient(element.GetComponent<SpriteRenderer>());
            }
        }
    }

    void Dimension()
    {
        foreach (GameObject element in gameObjects)
        {
            if (element.GetComponent<SpriteRenderer>() != null)
            {
                Function2D(element.GetComponent<SpriteRenderer>());
            }
            else if (element.GetComponent<MeshRenderer>() != null)
            {
                Function3D(element.GetComponent<MeshRenderer>());
            }
        }
    }

    void Function3D(MeshRenderer mesh)
    {
        if (mesh != null)
        {
            Debug.Log("This is a 3D object");
        }
    }

    void RotateCube(Transform cube)
    {
        float rotationAngle = (cube.position.x / 10f) * 360f;
        cube.rotation = Quaternion.Euler(rotationAngle, 0f, 0f);
    }

    void Function2D(SpriteRenderer sprite)
    {
        if (sprite != null)
        {
            Debug.Log("This is a 2D object");
        }
    }

    void SpriteGradient(SpriteRenderer sprite)
    {
        float yChange = sprite.transform.position.y / 10f;
        sprite.color = gradient.Evaluate(yChange);
    }
}
