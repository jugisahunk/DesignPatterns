﻿namespace DesignPatterns.Factory
{
    public abstract class WorldFactory
    {
        public abstract Character CreateCharacter();
        public abstract Monster CreateMonster();
    }

    public abstract class Monster
    {
    }

    public abstract class Character
    {
        public abstract void Attack( Monster monster );
    }
}
