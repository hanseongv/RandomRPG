using System;

namespace Script.Player
{
    public class CharacterProperties
    {
        private String nickName;
        private byte Level = 1;
        private int ExperiencePoint = 0;
        private byte SkillPoint = 1;
        private Ability ability;
    }

    public class Ability
    {
        private int HealthPoint;
        private int ManaPoint;
        private int StaminaPoint;
        private int AttackPower;
        private int CriticalPower;
        private int Defense;

        //확률
        private float Dodge;
        private float Block;
        private float Critical;

        private float Accuracy;

        //부가
        private float MoveSpeed;
        private float AttackSpeed;
        private float Sight;
    }
}