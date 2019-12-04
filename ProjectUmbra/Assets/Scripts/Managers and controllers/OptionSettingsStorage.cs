using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionSettingsStorage : MonoBehaviour
{

    private static OptionSettingsStorage instance;

    public static OptionSettingsStorage Instance { get { return instance; } }

    private static bool useOpenDyslexic = false;
    [SerializeField] private static Font OpenDyslexicFont;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }
    public static bool OpenDyslexic
    {
        get
        {
            return useOpenDyslexic;
        }
        set
        {
            useOpenDyslexic = value;
        }
    }

    public static Font GetOpenDyslexic()
    {
        return OpenDyslexicFont;
    }
}
