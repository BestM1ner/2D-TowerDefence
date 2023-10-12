using UnityEngine;
public enum projectyleType 
{
    arrow, fireball, rock
};
public class Projectile : MonoBehaviour
{
    [SerializeField]
    int attackDamage;

    [SerializeField]
    projectyleType pType;

    public int AttackDamage
    {
        get
        {
            return attackDamage;
        }
    }

    public  projectyleType PType
    {
        get
        {
            return pType;
        }
    }
}
    

