#pragma warning disable 0649
using UnityEngine;
using UnityEngine.UI;

public class Inventary : MonoBehaviour
{
    [SerializeField] private item[] items;
    [SerializeField] private Image[] images;
    [SerializeField] private Text[] amounts;
    private Canvas canvas;

    private void Awake()
    {
        if (canvas == null)
            canvas = gameObject.GetComponent<Canvas>();
    }

    private void Start() => UpdateUI();

    public void UpdateUI()
    {
        int length = items.Length;
        for (int i = 0; i < length; i++)
        {
            images[i].sprite = items[i].sprite;
            amounts[i].text = $"{items[i].amount}";
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
            canvas.enabled = !canvas.enabled;
    }
}
