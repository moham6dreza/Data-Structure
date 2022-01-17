using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication50
{
    class HashNode
    {
        public int key;
        public bool Deleted;
        public HashNode(int Key)
        {
            key = Key;
            Deleted = false;
        }
    }
}
