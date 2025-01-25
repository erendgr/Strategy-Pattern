using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellsUI : MonoBehaviour
{
    [SerializeField] private Button[] spellButtons;
    
    public static Action<int> OnSpellButtonPressed;

    private void Awake()
    {
        for (int i = 0; i < spellButtons.Length; i++)
        {
            int index = i;
            spellButtons[i].onClick.AddListener(() =>
            {
                HandleButtonPress(index);
            });
        }
    }

    private void HandleButtonPress(int index)
    {
        OnSpellButtonPressed?.Invoke(index);
    }
}