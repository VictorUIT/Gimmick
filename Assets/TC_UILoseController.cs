using Platformer.Core;
using Platformer.Gameplay;
using UnityEngine;
using UnityEngine.UI;

public class TC_UILoseController : MonoBehaviour
{
    [SerializeField] private Button btnReplay;
    private void Awake()
    {
        btnReplay.onClick.AddListener(() =>
        {
            Simulation.Schedule<PlayerSpawn>();
            Hide();
        });
    }
    public void Show()
    {
        gameObject.SetActive(true);
    }
    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
