using System;

abstract class Character
{
    private readonly string characterType;

    protected Character(string characterType)
    {
        this.characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return false;
    }

    public override string ToString() => $"Character is a {characterType}";
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (target.Vulnerable())
            return 10;
        else
            return 6;

    }
}

class Wizard : Character
{
    private  bool spellPrepared = false;
    public Wizard() : base("Wizard")
    {
    }

    public override bool Vulnerable()
    {
        if (spellPrepared)
            return base.Vulnerable();
        else
            return true;
    }
    public override int DamagePoints(Character target)
    {
        if (spellPrepared && target != null)
            return 12;
        else
            return 3;
    }

    public void PrepareSpell()
    {
        spellPrepared = true;
    }
}
