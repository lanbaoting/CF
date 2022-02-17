using Bll.Service;
using Entity;
using JW.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Text;

namespace JW.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseController : Controller
    {
        public    string GetPathBasePathUri(HttpRequest request)
        {
            return new StringBuilder()          
             .Append(request.PathBase)
             .Append(request.Path)           
             .ToString();
        }
        public  string GetParams(string path)
        {
           
            string[] strArr = path.Split('/').Where(s=> !string.IsNullOrEmpty(s)).ToArray();
            string paramsSring = strArr[strArr.Length - 1].ToLower().Replace(".html","");
            return paramsSring;
        }

    
 
        public string GetRouteName(string path, int index)
        {
            
            string[] strArr = path.Split('/').Where(s => !string.IsNullOrEmpty(s)).ToArray();
            string paramsSring = strArr[index].ToLower();
            return paramsSring;
        }


        public string GetPathSplit(string path, int index)
        {
            
            string[] strArr = path.Split('/').Where(s => !string.IsNullOrEmpty(s)).ToArray();
            string paramsSring = strArr[index].ToLower();
            return paramsSring;
        }


        public string GetParams(string path, int index)
        {
           
            string[] strArr = path.Split('/');
            string paramsSring = strArr[strArr.Length - 1].ToLower().Replace(".html", "");
            string paramSring = paramsSring.Split('_')[index];
            return paramSring;
        }

        public string[] GetParamsArr(string path)
        {
          
            string[] strArr = path.Split('/');
            string paramsSring = strArr[strArr.Length - 1].ToLower().Replace(".html", "");
            string[] paramArr = paramsSring.Split('_');
            return paramArr;
        }

        public IActionResult PageNotFound()
        {
          return RedirectToAction("Home", "Index"); 
        }

    }
}
