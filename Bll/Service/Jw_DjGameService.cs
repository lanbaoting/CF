using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
 

namespace Bll.Service
{
    public class Jw_DjGameService : BaseService
    {
      
        /// <summary>
        ///  通过单击游戏分类集合 
        ///  查询每个分类下的前14个游戏
        /// </summary>
        /// <returns></returns>
        public List<DjGameClassGame> GetDjGameGroupByClassList(List<int> gameClassIds)
        {
            try
            {
                var list = new List<DjGameClassGame>();
                foreach (var id in gameClassIds) 
                {
                    var gameList = Context.Jw_DjGame.Where(w => w.IsEnable && w.DjGameClassId == id).OrderByDescending(o => o.F_CreateDate).Select(s => new DjGame
                    {
                        Name = s.Name,
                        DjGameId = s.Id,
                        Size = s.Size,
                        LanguageName = s.LanguageName,
                        CoverMap = s.CoverMap
                    }).Take(14).ToList();
                    var model = new DjGameClassGame()
                    {
                        DjGameClassId = id,
                        DjGameGameList = gameList
                    };
                    list.Add(model);


                }
 
                return list;//list.ToList();
            }
            catch (Exception e)
            {
                return new List<DjGameClassGame>();
            }
            
           
        }

        /// <summary>       
        ///  通过主键获取游戏Id
        /// </summary>
        /// <returns></returns>
        public Jw_DjGame GetDjGameById(int djGameId)
        {
            try
            {
                var game = Context.Jw_DjGame.FirstOrDefault(w => w.IsEnable && w.Id == djGameId);
                return game;
            }
            catch (Exception e)
            {
                return null;
            } 
        }


        /// <summary>       
        ///  通过主键获取游戏Id
        /// </summary>
        /// <returns></returns>
        public IQueryable<Jw_DjGame> GetPageGameList(int djGameClassId)
        {
            try
            {
                var list = Context.Jw_DjGame.Where(w => w.IsEnable && w.DjGameClassId == djGameClassId);
               
               list = list.OrderByDescending(w => w.F_CreateDate);
               
                
                return list;
            }
            catch (Exception e)
            {
                return null;
            }
        }


        /// <summary>
        /// 前几条
        /// </summary>
        /// <param name="topCount"></param>
        /// <returns></returns>
        public List<Jw_DjGame> GetGameList(int topCount)
        {
            try
            {
                var list = Context.Jw_DjGame.Where(w => w.IsEnable ).OrderByDescending(o=>o.Sort).ThenByDescending(s=>s.F_CreateDate).Take(topCount).ToList();             
                return list;
            }
            catch (Exception e)
            {
                return null;
            }
        }





    }
}
