using System;

namespace Resource
{
    [Serializable]
    public class StaticState
    {
        public int level;
        public int maxhp;
        public int hp = 0;
        public int atk;
        public int def;
        public int teh;
        public int spd;
        public int luk;
        public int conducting = 0;
    }
}