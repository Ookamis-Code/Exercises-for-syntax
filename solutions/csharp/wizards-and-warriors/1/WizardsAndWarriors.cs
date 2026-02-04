abstract class Character
{
    protected Character(string characterType)
    {
        this.characterType = characterType;
    }
    private string characterType;

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => false;

    public override string ToString()
    {
        return $"Character is a {characterType}";
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (target.Vulnerable()) 
        {
            return 10;
        }
        else 
        {
            return 6;
        }
    }
}

class Wizard : Character
{
    private bool preparedSpell = false;
    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (this.preparedSpell) 
        {
            return 12;
        }
        else 
        {
            return 3;
        }
    }

    public void PrepareSpell()
    {
        this.preparedSpell = true;
    }
    public override bool Vulnerable() 
    {
        return !this.preparedSpell;
    }
}
