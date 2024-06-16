﻿using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core.Enemy
{
    public class Enemy_Klaed_Scout : Game_Enemy
    {
        private int actionTimer = 8;
        private int actionCD = 0;
        private int changeDirectionTimes = 5;
        private float velocityX = 0;
        private float velocityY = 1;
        private Game_EnemyWeapon weapon = null;
        public Enemy_Klaed_Scout(Game_Sprite sprite, float x, float y, float speed, Mode mode)
            : base(sprite, x, y)
        {
            _Width = sprite.Width;
            _Height = sprite.Height;
            _r = sprite.Width * 0.35f;
            _hp = 20;
            this.mode = mode;
            _MoveSpeed = Math.Max(speed, 0.1f); // Minimum speed is 0.1f
            _collideDamage = 100;
            weapon = Factory.Create_EnemyWeapon_Sniper(this, 0, 20);
            _reward = 50;
        }

        public override void Process_Action()
        {
            if (mode == Mode.following)
            {
                if (actionCD > 0)
                {
                    actionCD--;
                }
                else
                {
                    if (GameDataManager.player != null && changeDirectionTimes > 0)
                    {
                        PointF des = Utilities.GetVector(Center, GameDataManager.player.Center);
                        velocityX = des.X;
                        velocityY = des.Y;
                        changeDirectionTimes--;
                    }
                    actionCD = actionTimer;
                }
            }
            Move_Vector(velocityX, velocityY);
            if (GameDataManager.player != null)
            {
                Game_Player player = GameDataManager.player;
                if (Math.Abs(_x - player.x) < 400 && _y < player.y)
                {
                    weapon.Shoot();
                }
            }
            base.Process_Action();
        }

        public override void Update()
        {
            Process_Action();
            base.Update();
            Update_Data();
        }

        public override void Update_Data()
        {
            base.Update_Data();
            weapon.Update();
        }

        public override void Process_BeforeDie()
        {
            base.Process_BeforeDie();
            if (_die_ani)
            {
                PointF center = Center;
                Game_Animation ani = Factory.Create_ani_Explosion("enemy1", x, y);
                ani.ToCenterPoint(center.X, center.Y);
                AudioManager.PlaySE(SE.Explosion1);
            }
        }
    }
}
