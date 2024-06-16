﻿using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace Space_Shooter.Core
{
    public class Game_Bullet : Game_CollidableObject
    {
        protected Game_Object owner;
        protected string die_ani_sprite = "default_bullet";
        protected string die_ani_audio = SE.Explosion1;

        public Game_Object Owner {  get { return owner; } }

        public Game_Bullet(Game_Object owner, Game_Sprite sprite, float x, float y, float speed = 1)
            : base (sprite, x, y)
        {
            _z = 6;
            this.owner = owner;
            _MoveSpeed = speed;
            _frame_CD = 5;
            _IgnoreWall = true;
            _collideDamage = 1;
            _collidable = true;
            _hp = 1;
        }

        public bool IsPlayerBullet()
        {
            return owner != null && owner is Game_Player;
        }

        public override void Update()
        {
            Process_Action();
            base.Update();
            Update_Data();
        }

        override public void Process_Action()
        {
            Test_move_over_screen();
            base.Process_Action();
        }

        public override void CollidedWith(Game_CollidableObject src)
        {
            if (_die)
            {
                return;
            }
            if (src is Game_CollidableObject && !(src is Game_Bullet) && !src.IgnoreBullet && _team != src.Team)
            {
                if (!src.Immortal)
                {
                    src.HP -= _collideDamage;
                }
                if (!_immortal)
                {
                    _hp -= src.CollideDamage;
                }
            }
        }

        public override void Process_BeforeDie()
        {
            base.Process_BeforeDie();
            if (_die_ani)
            {
                Game_Animation animation = Factory.Create_ani_Explosion(die_ani_sprite, x, y);
                animation.ToCenterPoint(Center.X, Center.Y);
                AudioManager.PlaySE(die_ani_audio);
            }
        }
    }
}
