using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class Assignment3
    {
        /// <summary>
        /// Если у вас есть ключ дверь отркывается. Иначе ошибка ключа
        /// </summary>
        /// <param name="isKey">Ключ</param>
        /// <returns></returns>
        public Door OpenCabinet(bool isKey)
        {
            if (isKey==true )
            {
                return new OpenDoor();
            }
            return new ErrorNotKey();
        }
        public class ErrorNotKey : Door
        {
        }
        public class OpenDoor : Door
        {
        }
        public class Door
        {
        }
    }
}
