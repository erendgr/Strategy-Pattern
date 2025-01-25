using UnityEngine;

[CreateAssetMenu(menuName = "Spells/Magic Spell", fileName = "Magic Spell")]
public class MagicSpeelStrategy : AbilityStrategy
{
    [SerializeField] private GameObject magicParticlePrefab;
    [SerializeField] private float selfDestructionDuration;
    
    public override void UseAbility(Transform desiredPosition, Quaternion desiredRotation)
    {
        Vector3 newDesiredPosition = new Vector3(desiredPosition.position.x + 0.80f, desiredPosition.position.y + 0.40f, desiredPosition.position.z);
        GameObject magicInstance = Instantiate(magicParticlePrefab, newDesiredPosition, desiredRotation);
        Destroy(magicInstance, selfDestructionDuration);
    }
}