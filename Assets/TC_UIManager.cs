using UnityEngine;

public class TC_UIManager : MonoBehaviour
{
    public static TC_UIManager Instance;
    [SerializeField] private TC_UILoseController m_LoseController;

    public TC_UILoseController LoseController { get => m_LoseController; set => m_LoseController = value; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
}
