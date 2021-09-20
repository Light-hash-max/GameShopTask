using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int cost;

    public void Buy()
    {
        if (GetComponentInParent<Shop>().money >= cost)
        {
            GetComponentInParent<Shop>().money -= cost;
        }
    }
}
