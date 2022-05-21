using System.Collections.Generic;
using System;

namespace Domain
{
    public class Character
    {
        public string id;
        public string name;
        public string description = "";

        public int level = 1;
        public int maxhp;
        public int hp;
        public int atk;
        public int def;
        public int teh;
        public int spd;
        public int luk;
        public int move = 2;
        public int conducting = 0;
        public MoveType moveType = MoveType.walk;
        public List<CharacterAttribute> attributes;

        public int exp = 0;
        //public MoveType moveType;
    }
}
