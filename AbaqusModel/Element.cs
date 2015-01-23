﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abaqus
{
    public class Element
    {
        public uint id { get; private set; }
        private uint[] node_ids;
        public uint this[int n]{
            get { return node_ids[n]; }
            set { node_ids[n] = value; }
        }
        public string type { get; private set; }
        
        public Element(string type, string line)
        {
            this.type = type;
            var arr = line.Split(',').Select(s => uint.Parse(s));
            id = arr.First();
            node_ids = arr.Skip(1).ToArray();
        }


        internal Elements parent { get; set; }

        public Model model { get; set; }
    }
}