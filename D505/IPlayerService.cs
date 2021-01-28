using System;
using System.Collections.Generic;
using System.Text;

namespace D5O5
{
    interface IPlayerService
    {
        public void Add(Player player);
        public void Update(Player player);
        public void Delete(Player player);
    }
}
