using UnityEngine;
using UnityEngine.UI;

public class OnValueChangedSound : MonoBehaviour
{
    [SerializeField] private string soundName;

    void Start()
    {
        if(TryGetComponent(out Button button))
        {
            button.onClick.AddListener(PlaySound);
        }
    }

    void PlaySound()
    {
        if (FindObjectOfType<AudioManager>() != null)
        {
            FindObjectOfType<AudioManager>().Play(soundName);
        }
    }
}
