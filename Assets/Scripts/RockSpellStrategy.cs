using UnityEngine;

[CreateAssetMenu(menuName = "Spells/Rock Spell", fileName = "Rock Spell")]
public class RockSpellStrategy : AbilityStrategy
{
    [SerializeField] private GameObject rockParticlePrefab;
    [SerializeField] private float selfDestructionDuration;

    public override void UseAbility(Transform desiredPosition, Quaternion desiredRotation)
    {
        Vector3 newDesiredPosition = new Vector3(desiredPosition.position.x + 0.80f, desiredPosition.position.y + 0.40f,
            desiredPosition.position.z);
        GameObject rockInstance = Instantiate(rockParticlePrefab, newDesiredPosition, desiredRotation);
        Destroy(rockInstance, selfDestructionDuration);
    }
}