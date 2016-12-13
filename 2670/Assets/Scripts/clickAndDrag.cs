using UnityEngine;
using System.Collections;
using System;

public class clickAndDrag : MonoBehaviour {

    public Transform character;
    public Transform cube;
    public Transform ground;
	Vector3 screenPoint;
    Vector3 mousePosition;
    Vector3 offset;
    Vector3 movePosition;
    Vector3 clickPosition;

    public int i;

    public static Action<string> printValue;

    private bool c2d = false;

    void OnMouseDown()
    {
       
        print("You pick up the weapon!");
        Player.damage += Player.damage;
        cube.parent = character;

        if (c2d == true)
        {
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
            offset = gameObject.transform.position - Camera.main.WorldToScreenPoint(mousePosition);
        }
       i = 0;
    }

    void OnMouseDrag()
    {
        
        while (i < 1)
        {
            print("This will help defeat that foe! Just dont drop it!");
            i++;
        }
        if (c2d == true)
        {
            clickPosition = Input.mousePosition;
            movePosition = Camera.main.ScreenToWorldPoint(clickPosition) + offset;
            transform.position = movePosition;
        }
    }

    void OnMouseUp()
    {
        i = 0;
        print("You drop the weapon");
        cube.parent = ground;
        Player.damage /= 2;
    }
}
