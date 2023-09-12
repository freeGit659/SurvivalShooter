using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Light2DManager : MonoBehaviour
{
    [SerializeField] GameObject globalLight2D;
    [SerializeField] GameObject playerViewsLight2D;
    [SerializeField] Text timeText;
    [SerializeField] Text statusText;
    [SerializeField] GameObject dayNightCanvas;
    [SerializeField] SunCtrl sunCtrl;
    private const float REAL_SECONDS_PER_INGAME_DAY = 60f;
    private const float HOUR_PERDAY = 24f;
    private const float MINUS_PERHOUR = 60f;
    private float eighteenOclock = 18f;
    private float sixOclock = 6f;
    private float day;
    private string status;
    void Start()
    {
       SetTimeBegin();
       status = "day";
    }

    // Update is called once per frame
    void Update()
    {
        day += Time.deltaTime / REAL_SECONDS_PER_INGAME_DAY;
        if (day >= 1) day= 0;
        float dayNormalized = day % 1f;
        float hours = Mathf.Floor(dayNormalized * HOUR_PERDAY);
        float minus = Mathf.Floor(((dayNormalized * HOUR_PERDAY) % 1f) * MINUS_PERHOUR);
        string hoursString = hours.ToString("00");
        string minusString = minus.ToString("00");
        timeText.text = hoursString + ":" + minusString;
        Debug.Log("time:" +day);
        SetStatus();
    }
    public void InDayTime()
    {
        dayNightCanvas.SetActive(true);
        DataManager.canAttackPlayer = false;
        globalLight2D.SetActive(true);
        playerViewsLight2D.SetActive(false);
    }
    public void InNightTime()
    {
        dayNightCanvas.SetActive(true);
        DataManager.canAttackPlayer = false;
        globalLight2D.SetActive(false);
        playerViewsLight2D.SetActive(true);
    }
    private void SetTimeBegin()
    {
        day = sixOclock / HOUR_PERDAY;
    }
    private void SetStatus()
    {
        if(status == "day" && (day >= eighteenOclock / HOUR_PERDAY))
        {
            status = "night";
            InNightTime();
            statusText.text = "Night";
            statusText.color = Color.red;
            timeText.color= Color.red;
            StartCoroutine(sunCtrl.SunDown());
        }
        else if (status == "night" && (day >= sixOclock / HOUR_PERDAY && day < eighteenOclock / HOUR_PERDAY))
        {
            status = "day";
            InDayTime();
            statusText.text = "Day";
            statusText.color = Color.green;
            timeText.color = Color.green;
            StartCoroutine(sunCtrl.SunRise());
        }
    }
}
