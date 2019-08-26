using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneWars.Base
{
    /// <summary>
    /// 炮弹基类
    /// </summary>
    public abstract class BaseShell
    {
        /// <summary>
        /// 炮弹名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 炮弹飞行速度
        /// </summary>
        public float Speed { get; set; }

        /// <summary>
        /// 炮弹威力
        /// </summary>
        public float Power { get; set; }

        /// <summary>
        /// 子弹当前位置
        /// </summary>
        public Point Position { get; set; }

        public BaseShell()
        {
            Init("炮弹基类", 0, 0);
        }

        /// <summary>
        /// 初始化本类
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_speed"></param>
        /// <param name="_power"></param>
        protected virtual void Init(string _name,float _speed,float _power)
        {
            this.Name = _name;
            this.Speed = _speed;
            this.Power = _power;
        }
    }
}
