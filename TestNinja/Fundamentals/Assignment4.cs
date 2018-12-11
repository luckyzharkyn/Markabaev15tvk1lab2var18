using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class Assignment4
    {
        public int SaveLastVisited { get; set; }
        /// <summary>
        /// Записывает кто вошел в универ
        /// </summary>
        /// <param name="id">Номер зачетки</param>
        /// <param name="name">Имя</param>
        public void EntranceToUniver(int id, string name)
        {
            SaveLastVisited = id;
        }

    }
}
