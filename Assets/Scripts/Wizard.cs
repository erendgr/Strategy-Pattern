using UnityEngine;

public class Wizard : MonoBehaviour
{
    [SerializeField] private AbilityStrategy[] abilities;
    [SerializeField] private Animator animator;
    private const string IS_ATTACKING = "isAttacking";
    
    private void OnEnable()
    {
        SpellsUI.OnSpellButtonPressed += SpellsU_OnSpellButtonPressed;
    }

    private void SpellsU_OnSpellButtonPressed(int index)
    {
        abilities[index].UseAbility(this.transform, this.transform.rotation);
        animator.SetTrigger(IS_ATTACKING);
    }

    private void OnDisable()
    {
        SpellsUI.OnSpellButtonPressed -= SpellsU_OnSpellButtonPressed;
    }
}