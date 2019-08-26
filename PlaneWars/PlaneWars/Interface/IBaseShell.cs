using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneWars.Interface
{
    public interface IBaseShell
    {
        /// <summary>
        /// 炮弹移动
        /// </summary>
        void Move();

        /// <summary>
        /// 发射炮弹
        /// </summary>
        void Create();
    }
}
