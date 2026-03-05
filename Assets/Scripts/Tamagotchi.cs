using TMPro;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Tamagotchi", menuName = "Scriptable Objects/Tamagotchi")]
public class Tamagotchi : MonoBehaviour
{
    [SerializeField] private Button feedButton;
    [SerializeField] private Button playButton;
    [SerializeField] private Button cleanButton;
    
    [SerializeField] private Slider hungerSlider;
    [SerializeField] private Slider moodSlider;
    [SerializeField] private Slider cleanlinessSlider;
    
    [SerializeField] private TMP_Text hungerValue;
    [SerializeField] private TMP_Text moodValue;
    [SerializeField] private TMP_Text cleanlinessValue;

    private int hunger;
    private int mood;
    private int cleanliness;

    public void Awake()
    {
        hungerSlider.value = hunger = 50;
        hungerValue.text = $"{hunger}";
        
        moodSlider.value = mood = 50;
        moodValue.text = $"{mood}";
        
        cleanlinessSlider.value = cleanliness = 50;
        cleanlinessValue.text = $"{cleanliness}";
    }
    
}
