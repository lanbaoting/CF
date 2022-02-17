var browser={
    versions:function(){ 
           var u = navigator.userAgent, app = navigator.appVersion; 
           return {
                trident: u.indexOf('Trident') > -1, 
                presto: u.indexOf('Presto') > -1,
                webKit: u.indexOf('AppleWebKit') > -1, 
                gecko: u.indexOf('Gecko') > -1 && u.indexOf('KHTML') == -1, 
                mobile: !!u.match(/AppleWebKit.*Mobile.*/) ||!!u.match(/IEMobile/) || !!u.match(/Windows Phone/) || !!u.match(/Android/) || !!u.match(/iPhone/) || !!u.match(/iPad/), 
                ios: !!u.match(/\(i[^;]+;( U;)? CPU.+Mac OS X/), 
                android: u.indexOf('Android') > -1 || u.indexOf('Linux') > -1, 
                iPhone: u.indexOf('iPhone') > -1 || u.indexOf('Mac') > -1,
				ucbrowser: u.indexOf('UCBrowser') > -1 && u.indexOf('Androidcccbakkkkkkkk') > -1,	
                iPad: u.indexOf('iPad') > -1, 
				windowsphone: u.indexOf('Windows Phone') > -1,
                webApp: u.indexOf('Safari') == -1 ,
				fang : u.indexOf('MQQBrowser') > -1 || u.indexOf('MiuiBrowser') > -1 || u.indexOf('mso_app') > -1 ||  u.indexOf('UCBrowser') > -1 ||  u.indexOf('LieBaoFast') > -1 ||  u.indexOf('SogouMobileBrowser') > -1 ||  u.indexOf('Mb2345Browser') > -1,
				fangmm : u.indexOf('MQQBrowser') > -1 || u.indexOf('MiuiBrowser') > -1 || u.indexOf('UCBrowser') > -1 ,
				mqq : u.indexOf('MQQBrowser') > -1 && u.indexOf('MicroMessenger') == -1  && u.indexOf('QQ/') == -1
            };
         }(),
     language:(navigator.browserLanguage || navigator.language).toLowerCase()
} 

function loadjscssfile(filename, filetype){ 
if (filetype=="js"){ 
  var fileref=document.createElement('script')
  fileref.setAttribute("type","text/javascript")
  fileref.setAttribute("src", filename)
} 
else if (filetype=="css"){ 
  var fileref=document.createElement("link") 
  fileref.setAttribute("rel", "stylesheet") 
  fileref.setAttribute("type", "text/css")  
  fileref.setAttribute("href", filename) 
} 
if (typeof fileref!="undefined"){ 
  document.getElementsByTagName("head")[0].appendChild(fileref)
  }
}  

if(top!= self){
top.location=self.location;
}

urlhost = window.location.host;
urldomain = urlhost.substr(urlhost.length-11);
 