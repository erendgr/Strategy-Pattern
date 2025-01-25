using UnityEngine;

[CreateAssetMenu(menuName = "Spells/Vine Spell", fileName = "Vine Spell")]
public class VineSpellStrategy : AbilityStrategy
{
    [SerializeField] private GameObject vineParticlePrefab;
    [SerializeField] private float selfDestructionDuration;

    public override void UseAbility(Transform desiredPosition, Quaternion desiredRotation)
    {
        Vector3 newDesiredPosition = new Vector3(desiredPosition.position.x + 0.80f, desiredPosition.position.y + 0.40f,
            desiredPosition.position.z);
        GameObject vineInstance = Instantiate(vineParticlePrefab, newDesiredPosition, desiredRotation);
        Destroy(vineInstance, selfDestructionDuration);
    }
}