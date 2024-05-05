﻿using Space_Shooter.Core;
using Space_Shooter.Core.Bullet;
using Space_Shooter.Core.Enemy;
using Space_Shooter.Core.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Manager
{
    internal class Factory
    {

        #region Damageable entities
        public static Game_Player Create_PlayerSpaceship(float x, float y)
        {
            return new Game_Player(SpriteManager.Sprites["player1"], x, y);
        }



        public static Enemy_Meteor Create_Meteor(int size, float x, float y, float vx = 0, float vy = 1, float speed = 6, bool AddToData = true)
        {
            Enemy_Meteor obj = new Enemy_Meteor(SpriteManager.Sprites["meteor_size" + size], x, y, size, vx, vy, speed);
            if (AddToData)
                GameDataManager.enemies.Add(obj);
            return obj;
        }
        #endregion

        #region Item
        public static Game_Item Create_Item_Shotgun(float x, float y, bool AddToData = true)
        {
            Game_Item item = new Game_Item(SpriteManager.Sprites[ItemID.WeaponShotgun], x, y, ItemID.WeaponShotgun);
            if (AddToData)
                GameDataManager.enemies.Add(item);
            return item;
        }

        public static Game_Item Create_Item_Piercing(float x, float y, bool AddToData = true)
        {
            Game_Item item = new Game_Item(SpriteManager.Sprites[ItemID.WeaponPiercingGun], x, y, ItemID.WeaponPiercingGun);
            if (AddToData)
                GameDataManager.enemies.Add(item);
            return item;
        }

        public static Game_Item Create_Item_Bio(float x, float y, bool AddToData = true)
        {
            Game_Item item = new Game_Item(SpriteManager.Sprites[ItemID.WeaponBioSprayer], x, y, ItemID.WeaponBioSprayer);
            if (AddToData)
                GameDataManager.enemies.Add(item);
            return item;
        }

        public static Game_Item Create_Item_Gatling(float x, float y, bool AddToData = true)
        {
            Game_Item item = new Game_Item(SpriteManager.Sprites[ItemID.WeaponGatlingGun], x, y, ItemID.WeaponGatlingGun);
            if (AddToData)
                GameDataManager.enemies.Add(item);
            return item;
        }

        public static Game_Item Create_Item_Rocket(float x, float y, bool AddToData = true)
        {
            Game_Item item = new Game_Item(SpriteManager.Sprites[ItemID.WeaponRocket], x, y, ItemID.WeaponRocket);
            if (AddToData)
                GameDataManager.enemies.Add(item);
            return item;
        }

        public static Game_Item Create_Item_Flamethrower(float x, float y, bool AddToData = true)
        {
            Game_Item item = new Game_Item(SpriteManager.Sprites[ItemID.WeaponFlamethrower], x, y, ItemID.WeaponFlamethrower);
            if (AddToData)
                GameDataManager.enemies.Add(item);
            return item;
        }

        public static Game_Item Create_Item_Coin(float x, float y, bool AddToData = true)
        {
            Game_Item item = new Game_Item(SpriteManager.Sprites[ItemID.ItemCoin], x, y, ItemID.ItemCoin);
            if (AddToData)
                GameDataManager.enemies.Add(item);
            return item;
        }

        public static Game_Item Create_Item_Heal(float x, float y, bool AddToData = true)
        {
            Game_Item item = new Game_Item(SpriteManager.Sprites[ItemID.ItemHealPack], x, y, ItemID.ItemHealPack);
            if (AddToData)
                GameDataManager.enemies.Add(item);
            return item;
        }
        #endregion

        #region Bullets
        public static Bullet_DefaultBullet Create_DefaultBullet(Game_Object owner, float x, float y)
        {
            Bullet_DefaultBullet bullet = new Bullet_DefaultBullet(owner, SpriteManager.Sprites["default_bullet"], x, y);
            GameDataManager.bullets.Add(bullet);
            return bullet;
        }
        public static Bullet_Shotgun Create_ShotgunBullet(Game_Object owner, float x, float y)
        {
            Bullet_Shotgun bullet = new Bullet_Shotgun(owner, SpriteManager.Sprites["shotgun"], x, y);
            GameDataManager.bullets.Add(bullet);
            return bullet;
        }
        public static Bullet_Bio Create_BioBullet(Game_Object owner, float x, float y, float speed)
        {
            Bullet_Bio bullet = new Bullet_Bio(owner, SpriteManager.Sprites["bio"], x, y, speed);
            GameDataManager.bullets.Add(bullet);
            return bullet;
        }

        public static Bullet_Gatling Create_GatlingBullet(Game_Object owner, float x, float y)
        {
            Bullet_Gatling bullet = new Bullet_Gatling(owner, SpriteManager.Sprites["gatling"], x, y);
            GameDataManager.bullets.Add(bullet);
            return bullet;
        }

        public static Bullet_Piercing Create_PiercingBullet(Game_Object owner, float x, float y)
        {
            Bullet_Piercing bullet = new Bullet_Piercing(owner, SpriteManager.Sprites["pierce"], x, y);
            GameDataManager.bullets.Add(bullet);
            return bullet;
        }

        public static Bullet_Rocket Create_RocketBullet(Game_Object owner, float x, float y)
        {
            Bullet_Rocket bullet = new Bullet_Rocket(owner, SpriteManager.Sprites["rocket"], x, y);
            GameDataManager.bullets.Add(bullet);
            return bullet;
        }

        public static Bullet_Flame Create_FlameBullet(Game_Object owner, float x, float y)
        {
            Bullet_Flame bullet = new Bullet_Flame(owner, SpriteManager.Sprites["flame"], x, y);
            GameDataManager.bullets.Add(bullet);
            return bullet;
        }

        #endregion

        #region Animation

        ///<summary>
        ///Type is the animation id without explo_ prefix
        ///x, y is the center point of the animation
        ///</summary>
        public static Game_Animation Create_ani_Explosion(string type, float x, float y)
        {
            Game_Animation ani = new Game_Animation(SpriteManager.Sprites["explo_" + type], x, y);
            GameDataManager.animations.Add(ani);
            ani.ToCenterPoint(x, y);
            return ani;
        }

        public static Game_Animation Create_ani_Break(string type, float x, float y)
        {
            Game_Animation ani = new Game_Animation(SpriteManager.Sprites["break_" + type], x, y);
            ani.ToCenterPoint(x, y);
            GameDataManager.animations.Add(ani);
            return ani;
        }
        #endregion

        #region Weapon

        public static Weapon_Default Create_PlayerWeapon_Default(Game_CollidableObject owner)
        {
            return new Weapon_Default(owner, 0, -owner.Height / 4);
        }

        public static Weapon_Shotgun Create_PlayerWeapon_Shotgun(Game_CollidableObject owner)
        {
            return new Weapon_Shotgun(owner, 0, -owner.Height / 4);
        }

        public static Weapon_Bio Create_PlayerWeapon_Bio(Game_CollidableObject owner)
        {
            return new Weapon_Bio(owner, owner.Width * 0.4f, -owner.Height / 4);
        }

        public static Weapon_Flamethrower Create_PlayerWeapon_Flamethrower(Game_CollidableObject owner)
        {
            return new Weapon_Flamethrower(owner, owner.Width * 0.4f, -owner.Height / 4);
        }

        public static Weapon_Gatling Create_PlayerWeapon_Gatling(Game_CollidableObject owner)
        {
            return new Weapon_Gatling(owner, owner.Width * 0.4f, -owner.Height / 4);
        }

        public static Weapon_Rocket Create_PlayerWeapon_Rocket(Game_CollidableObject owner)
        {
            return new Weapon_Rocket(owner, owner.Width * 0.4f, -owner.Height / 4);
        }

        public static Weapon_Piercing Create_PlayerWeapon_Piercing(Game_CollidableObject owner)
        {
            return new Weapon_Piercing(owner, owner.Width * 0.4f, -owner.Height / 4);
        }
        #endregion
    }
}
