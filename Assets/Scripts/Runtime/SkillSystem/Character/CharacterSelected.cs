using UnityEngine;
using System.Collections;

public class CharacterSelected : MonoBehaviour
{
    private GameObject selectedGO;
    public string selectedName = "";

    public int displayTime = 3;
    private void Start()
    {
        selectedGO = transform.Find(selectedName).gameObject;
    }

    private float hideTime;
    public void SetSelectedActive(bool state)
    {
        selectedGO.SetActive(state);

        this.enabled = state; //开启停止Update
        if (state)
        {
            hideTime = Time.time + 3;
        }
    }

    private void Update()
    {
        if(hideTime <= Time.time + displayTime)
        {
            SetSelectedActive(false);
        }
    }
}
