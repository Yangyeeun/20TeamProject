using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SliderTest : MonoBehaviour
{
    [SerializeField] public Slider Opprtunity;
    public GameObject EndPanel;
    [SerializeField] private Text TextName;
    [SerializeField] private Image ImageName;

    private float SliderTime = 1f;
    private float currentSliderTime = 0f;

    private float currentTime = 10f;
    private float delayTime = 10f;

    private bool IsClick;
    private bool IsCoolTime = false;
    // Start is called before the first frame update
    void Start()
    {
        currentSliderTime = SliderTime;
        EndPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Slider
        
            if (Opprtunity.value < 0f)
            {
                EndPanel.SetActive(true);
            }
        
        //Image
        if (IsCoolTime)
        {
            currentTime -= Time.deltaTime;
            ImageName.fillAmount = currentTime / delayTime;
            if (Opprtunity.value > 0f)
            {
                if (currentTime <= 0)
                {
                    IsCoolTime = false;
                    currentTime = delayTime;
                    ImageName.fillAmount = currentTime;
                    Opprtunity.value -= 2f;
                }
            }
            else
            {
                ImageName.fillAmount = 0;
            }
        }
    }
    public void ClickButton()
    {
        Opprtunity.value -= 2f;
        IsClick = true;
    }

    public void Change()
    {
        
        IsCoolTime = true;
    }
}
