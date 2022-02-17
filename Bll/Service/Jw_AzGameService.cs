using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
 

namespace Bll.Service
{
    public class Jw_AzGameService : BaseService
    {
      
        /// <summary>
        ///  通过单击游戏分类集合 
        ///  查询每个分类下的前14个游戏
        /// </summary>
        /// <returns></returns>
        public List<DjGameClassGame> GetAzGameGroupByClassList(List<int> gameClassIds)
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
        public Jw_AzGame GetAzGameById(int azGameId)
        {
            try
            {
                var game = Context.Jw_AzGame.FirstOrDefault(w => w.IsEnable && w.Id == azGameId);
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
        public IQueryable<Jw_AzGame> GetPageGameList(int azGameClassId)
        {
            try
            {
                var list = Context.Jw_AzGame.Where(w => w.IsEnable && w.AzGameClassId == azGameClassId);
               
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
        public List<Jw_AzGame> GetGameList(int topCount)
        {
            try
            {
                var list = Context.Jw_AzGame.Where(w => w.IsEnable ).OrderByDescending(o=>o.Sort).ThenByDescending(s=>s.F_CreateDate).Take(topCount).ToList();             
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
        public List<AzGame> GetGameList(int azClassId,int topCount)
        {
            try
            {
                var list = Context.Jw_AzGame.Where(w => w.IsEnable && w.AzGameClassId == azClassId).OrderByDescending(s => s.F_CreateDate).Select(s=>new AzGame { 
                AzGameId =s.Id,
                AzGameName = s.Name,              
                CoverMap = s.CoverMap,
                F_CreateDate =s.F_CreateDate
                }).Take(topCount).ToList();
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
        public List<AzGame> GetGameSortCreateDateList(int topCount)
        {
            try
            {
                var azGames = Context.Jw_AzGame.Where(w => w.IsEnable);
                var azGameClasss = Context.Jw_AzGameClass.Where(w => w.IsEnable); ;
                var list = from azGame in azGames
                           join azGameClass in azGameClasss on azGame.AzGameClassId equals azGameClass.Id
                           select new AzGame
                           {
                               AzGameId = azGame.Id,
                               AzGameName = azGame.Name,
                               AzGameClassCode = azGameClass.Code,
                               AzGameClassName = azGameClass.Name,
                               F_CreateDate = azGame.F_CreateDate,
                               CoverMap = azGame.CoverMap,
                               GameSize = azGame.GameSize

                           };

                return list.OrderByDescending(s => s.F_CreateDate).Take(topCount).ToList();

            }
            catch (Exception e)
            {
                return null;
            }
        }
        





    }
}
