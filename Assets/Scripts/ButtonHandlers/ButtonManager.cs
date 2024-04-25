using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager :MonoBehaviour
{
    // Start is called before the first frame update

    public void Enable(GameObject obj)
    {
        obj.SetActive(true);
    }
    public void Disable(GameObject obj)
    {
        obj.SetActive(false);
    }
    public void DestroyObject(GameObject obj)
    {
        Destroy(obj);
    }
}
