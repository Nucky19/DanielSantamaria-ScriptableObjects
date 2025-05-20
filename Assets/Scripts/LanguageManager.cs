using UnityEngine;
using UnityEngine.UI;

public class LanguageManager : MonoBehaviour
{
    public Text[] texts; // ← Ahora usa el componente Text normal

    public LanguageData spanish;
    public LanguageData english;
    public LanguageData french;

    public void SetSpanish()
    {
        ApplyLanguage(spanish);
    }

    public void SetEnglish()
    {
        ApplyLanguage(english);
    }

    public void SetFrench()
    {
        ApplyLanguage(french);
    }

    void ApplyLanguage(LanguageData language)
    {
        texts[0].text = language.text1;
        texts[1].text = language.text2;
        texts[2].text = language.text3;
        texts[3].text = language.text4;
    }
}
