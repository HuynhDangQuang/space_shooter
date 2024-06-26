﻿using Space_Shooter.AccountManagement.Model;
using Space_Shooter.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Shooter.Manager
{
    public static class Utilities
    {
        static public PointF GetVector(PointF src, PointF des)
        {
            return new PointF(des.X - src.X, des.Y - src.Y);
        }
    
        static public Game_Enemy.Mode ParseMode(string modeStr)
        {
            switch (modeStr)
            {
                case "following":
                    return Game_Enemy.Mode.following;
                case "forward":
                    return Game_Enemy.Mode.forward;
                default:
                    return Game_Enemy.Mode.forward;
            }
        }

        static public SortedDictionary<int, List<Game_Object>> CloneStageObjects(SortedDictionary<int, List<Game_Object>> src)
        {
            SortedDictionary<int, List<Game_Object>> clone = new SortedDictionary<int, List<Game_Object>>();

            foreach (KeyValuePair<int, List<Game_Object>> entry in src)
            {
                clone.Add(entry.Key, entry.Value);
            }

            return clone;
        }

        static public int CompareUserResult(User user1, User user2, string difficulty)
        {
            if (user1.highestScore != user2.highestScore)
            {
                return user1.highestScore[difficulty] - user2.highestScore[difficulty];
            }
            else
            {
                return user2.playTime[difficulty] - user1.playTime[difficulty];
            }
        }
    }
}
