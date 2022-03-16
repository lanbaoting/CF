using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Cf_FactoryHouseDictionaryService : BaseService
    {
      
        /// <summary>
        /// 通过边号获取字典
        /// </summary>
        /// <returns></returns>
        public Cf_FactoryHouseDictionary GetDictionaryByCode(string code)
        {
            var factoryHouseDictionary = Context.Cf_FactoryHouseDictionary.FirstOrDefault(w => w.IsEnable && w.Code == code);
            return factoryHouseDictionary;
        }

        /// <summary>
        /// 通过边号获取字典
        /// </summary>
        /// <returns></returns>
        public List<Cf_FactoryHouseDictionary> GetFactoryHouseDictionaryListByCodes(List<string> codes)
        {
            var factoryHouseDictionarys = Context.Cf_FactoryHouseDictionary.Where(w => w.IsEnable && codes.Contains(w.Code));
            return factoryHouseDictionarys.ToList();
        }

        /// <summary>
        /// 通过边号获取字典
        /// </summary>
        /// <returns></returns>
        public List<Cf_FactoryHouseDictionary> GetFactoryHouseDictionaryListByParentIds(List<int> ids)
        {    
            var factoryHouseDictionarys = Context.Cf_FactoryHouseDictionary.Where(w => w.IsEnable && ids.Contains(w.ParentId.Value) );
            return factoryHouseDictionarys.ToList();
        }


        /// <summary>
        /// 通过边号获取字典
        /// </summary>
        /// <returns></returns>
        public List<Cf_FactoryHouseDictionary> GetFactoryHouseDictionaryListByIds(List<int> ids)
        {
            var factoryHouseDictionarys = Context.Cf_FactoryHouseDictionary.Where(w => w.IsEnable && ids.Contains(w.Id));
            return factoryHouseDictionarys.ToList();
        }


        /// <summary>
        /// 通过边号获取字典
        /// </summary>
        /// <returns></returns>
        public List<Cf_FactoryHouseDictionary> GetDictionaryByParentId(int parentId)
        {
            var list = Context.Cf_FactoryHouseDictionary.Where(w => w.IsEnable && w.ParentId == parentId).OrderBy(s=>s.Sort).ToList();
            return list;
        }

      




        ///// <summary>
        ///// 通过边号获取字典
        ///// </summary>
        ///// <returns></returns>
        //public List<FactoryHouseDictionary> GetDictionaryList(List<string> codes)
        //{

        //    var dictionarys1 = Context.Cf_FactoryHouseDictionary.Where(w => w.IsEnable && codes.Contains(w.Code));
        //    var dictionarys2 = Context.Cf_FactoryHouseDictionary.Where(w => w.IsEnable);

        //    var list = from dictionary1 in dictionarys1
        //               join dictionary2 in dictionarys2 on dictionary1.Id equals dictionary2.ParentId
        //               select new
        //               {
        //                   Id1 = dictionary1.Id,
        //                   Name1 = dictionary1.Name,
        //                   Sort1 = dictionary1.Sort,
        //                   Code1 = dictionary1.Code,
        //                   Id2 = dictionary2.Id,
        //                   Name2 = dictionary2.Name,
        //                   ParentId2 = dictionary2.ParentId,
        //                   Sort2 = dictionary2.Sort,
        //                   Code2 = dictionary2.Code
        //               };

        //    var dics = list.ToList().GroupBy(s => s.Id1).Select(s => new FactoryHouseDictionary
        //    {
        //        Id = s.Key,
        //        Name = s.FirstOrDefault().Name1,
        //        Sort = s.FirstOrDefault().Sort1,
        //        Code = s.FirstOrDefault().Code1,
        //        FactoryHouseDictionaryList = s.Select(m => new FactoryHouseDictionary { Id = m.Id2, Name = m.Name2, Sort = m.Sort2 }).ToList()

        //    });

        //    return dics.ToList();
        //}



    }
}
