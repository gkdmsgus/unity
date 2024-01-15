using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DigitalClock : MonoBehaviour
{
    public Sprite[] numberSprites;
    public Sprite[] daySprites;
    public SpriteRenderer hourRenderer, minuteRenderer, secondRenderer, dayRenderer;
    // Start is called before the first frame update
    void Start()
    {
        numberSprites = Resources.LoadAll<Sprite>("NumberSpriteSheet");
        daySprites = Resources.LoadAll<Sprite>("DaySpriteSheet");
    }

    // Update is called once per frame
    void Update()
    {
        float virtualTime = Time.time * 20 / 1440; // 가상의 시간 (하루가 20분)
        int hour = ((int)virtualTime) % 24;
        int minute = ((int)(virtualTime * 60)) % 60;
        int second = ((int)(virtualTime * 3600)) % 60;
        int day = ((int)virtualTime / 24) % 7; // 요일 (0 = Sunday, 1 = Monday, ..., 6 = Saturday)

        hourRenderer.sprite = numberSprites[hour / 10];
        minuteRenderer.sprite = numberSprites[minute / 10];
        secondRenderer.sprite = numberSprites[second / 10];
        dayRenderer.sprite = daySprites[day];
    }
}
