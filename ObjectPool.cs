using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public List<GameObject> list;

    private GameObject tObject;
    private GameObject _prefab;

    public ObjectPool(GameObject prefab, int depth)
    {
        _prefab = prefab;
        for (int i = 0; i < depth; i++)
        {
            tObject = Instantiate(prefab);
            tObject.SetActive(false);
            list.Add(tObject);
        }
    }

    private GameObject returnObj;
    public GameObject GetObject()
    {
        if (list.Count <= 0)
        {
            GameObject g = Instantiate(_prefab);
            g.SetActive(false);
            list.Add(g);
        }

        foreach (var item in list)
        {
            if (!item.activeInHierarchy)
            {
                returnObj = item;
                returnObj.SetActive(true);
            }
        }
        return returnObj;
    }
     
}
