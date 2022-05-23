using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Domain
{
    public class Stage
    {
        public string id;
        public string name;

        public string mapFile;
        public int maxWidth = 6;
        public int maxHeight = 8;

        public List<Field.Team> teams;
    }
}
