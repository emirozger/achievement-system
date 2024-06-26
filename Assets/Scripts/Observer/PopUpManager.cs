using UnityEngine;

public class PopUpManager : MonoBehaviour
{
    public static PopUpManager Instance;

    public PopUp popUp;
    public GameObject canvas;

 
    private void Awake()
    {
        Instance = this;
    }

    public void Create(string tittle, string description, float durability)
    {
        GameObject panel = Instantiate(popUp.gameObject, new Vector3(220, -630,0), Quaternion.identity);
        panel.transform.SetParent(canvas.transform);
        panel.transform.GetComponent<PopUp>().Tittle.text = tittle;
        panel.transform.GetComponent<PopUp>().Description.text = description;
        panel.transform.GetComponent<PopUp>().Durability = durability;
    }
}