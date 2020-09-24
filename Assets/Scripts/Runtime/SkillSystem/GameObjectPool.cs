using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameObjectPool : MonoBehaviour
{
    private Dictionary<string, List<GameObject>> cache;

    public  void Init()
    {
        cache = new Dictionary<string, List<GameObject>>();
    }

    public GameObject CreateObject(string key, GameObject prefab,Vector3 pos, Quaternion rotate)
    {
        GameObject go = null;
        if(cache.ContainsKey(key))
            go = cache[key].Find(g => !g.activeInHierarchy);

        if (go == null)
            go = Instantiate(prefab);
            if (!cache.ContainsKey(key)) cache.Add(key, new List<GameObject>());
            cache[key].Add(go);

        go.transform.position = pos;
        go.transform.rotation = rotate;
        go.SetActive(true);

        return go;

    }

    //回收对象
    public void CollectObject(GameObject go, float delay = 0)
    {
        StartCoroutine(CollectObjectDelay(go, delay));
    }

    private IEnumerator CollectObjectDelay(GameObject go, float delay)
    {
        yield return new WaitForSeconds(delay);
        go.SetActive(false);

    }

    public void Clear(string key)
    {
        foreach(var item in cache[key])
        {
            Destroy(item);
        }
        cache.Remove(key);
    }

    public void ClearAll()
    {
        List<string> keyList = new List<string>(cache.Keys);
        foreach(var key in keyList)
        {
            Clear(key);
        }
    }
}
