using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

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

    private float hunger;
    private float mood;
    private float cleanliness;

    private float cooldown;
    private float timer;

    public void Awake()
    {
        hungerSlider.value = hunger = 100f;
        hungerValue.text = $"{hunger}";
        
        moodSlider.value = mood = 100f;
        moodValue.text = $"{mood}";
        
        cleanlinessSlider.value = cleanliness = 100f;
        cleanlinessValue.text = $"{cleanliness}";

        cooldown = 2f;
        timer = 0f;
    }

    public void Update()
    {
        hunger -= 1f * Random.Range(1f, 5f) * Time.deltaTime;
        hungerSlider.value = hunger;
        hungerValue.text = $"{Math.Round(hunger)}";
        
        mood -= Random.Range(1f, 5f) * Time.deltaTime;
        moodSlider.value = mood;
        moodValue.text = $"{Math.Round(mood)}";
        
        cleanliness -= Random.Range(1f, 5f) * Time.deltaTime;
        cleanlinessSlider.value = cleanliness;
        cleanlinessValue.text = $"{Math.Round(cleanliness)}";
        
    }

    public void Feed()
    {
        if (Time.time >= timer)
        {
            switch (hunger + 10)
            {
                case >100:
                    hunger = 100f;
                    break;
                default:
                    hunger += 10;
                    break;
            }
            
            timer = Time.time + cooldown;
            Debug.Log(timer);
        }
    }

    public void Clean()
    {
        cleanliness += 2;
    }

    public void Play()
    {
        mood += 2;
    }
    
    
}
