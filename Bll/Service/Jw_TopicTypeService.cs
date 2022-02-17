using Entity;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_TopicTypeService : BaseService
    {
      
        /// <summary>
        ///  
        /// </summary>
        /// <returns></returns>
        public List<Jw_TopicType> GetTopicTypeList()
        {
            try
            {
                var list = Context.Jw_TopicType.Where(w=>w.IsEnable).ToList();
                return list;
            }
            catch (Exception e)
            {
                return new List<Jw_TopicType>();
            }
            
           
        }

        

        /// <summary>       
        ///  通过编号获取文章类别
        /// </summary>
        /// <returns></returns>
        public Jw_TopicType GetTopicTypeByCode(string code)
        {
            try
            {
                var topicType = Context.Jw_TopicType.FirstOrDefault(w => w.IsEnable && w.Code == code);
                return topicType;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
