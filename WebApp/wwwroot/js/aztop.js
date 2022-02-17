addScript("//www.99danji.com/api.php?op=getIp&format=js",function(){
 province = remote_ip_info["province"];
    city = remote_ip_info["city"];
    var datalist = {"data":[{"downurl":"\/\/m.99danji.com\/az\/38752\/","thumb":"\/\/img.99danji.com\/uploadfile\/2019\/0128\/20190128032124868.png","dkfs":"0","name":"\u5f39\u5f39\u5802","area":""},{"downurl":"\/\/m.99danji.com\/az\/120266\/","thumb":"\/\/img.99danji.com\/uploadfile\/2019\/0128\/20190128032027661.png","dkfs":"0","name":"\u9b54\u57df\u6765\u4e86","area":""},{"downurl":"\/\/m.99danji.com\/az\/889396\/","thumb":"\/\/img.99danji.com\/uploadfile\/2019\/0128\/20190128032430554.png","dkfs":"0","name":"\u7ea2\u8b66ol","area":""},{"downurl":"\/\/m.99danji.com\/az\/888856\/","thumb":"\/\/img.99danji.com\/uploadfile\/2019\/0128\/20190128032602743.png","dkfs":"0","name":"\u4e00\u5200\u4f20\u4e16","area":""},{"downurl":"\/\/m.99danji.com\/az\/129929\/","thumb":"\/\/img.99danji.com\/uploadfile\/2019\/0128\/20190128032715843.jpg","dkfs":"0","name":"\u4f8d\u9b42\u80e7\u6708\u4f20\u8bf4","area":""},{"downurl":"\/\/m.99danji.com\/az\/4043\/","thumb":"\/\/img.99danji.com\/uploadfile\/2018\/1102\/20181102025635992.png","dkfs":"0","name":"\u8c0b\u5b9a\u4e09\u56fd","area":""},{"downurl":"\/\/m.99danji.com\/az\/119326\/","thumb":"\/\/img.99danji.com\/uploadfile\/2018\/0914\/20180914021920323.png","dkfs":"0","name":" \u51b3\u6218\u6b66\u9053\u4f1a","area":""},{"downurl":"\/\/m.99danji.com\/az\/50727\/","thumb":"\/\/img.99danji.com\/uploadfile\/2018\/0914\/20180914023816877.png","dkfs":"0","name":"QQ\u70ab\u821e","area":""},{"downurl":"\/\/m.99danji.com\/az\/36516\/","thumb":"\/\/img.99danji.com\/uploadfile\/2018\/1102\/20181102025846896.png","dkfs":"0","name":"\u6218\u59ec\u5c11\u5973","area":""},{"downurl":"\/\/m.99danji.com\/az\/116563\/","thumb":"\/\/img.99danji.com\/uploadfile\/2018\/0914\/20180914022205683.png","dkfs":"0","name":"\u767d\u86c7\u5bfb\u4ed9","area":""},{"downurl":"\/\/m.99danji.com\/az\/122664\/","thumb":"\/\/img.99danji.com\/uploadfile\/2018\/0914\/20180914024114490.png","dkfs":"0","name":"\u6211\u662f\u5927\u9b54\u738b","area":""},{"downurl":"\/\/www.99danji.com\/az\/113324\/","thumb":"\/\/img.99danji.com\/uploadfile\/2018\/1102\/20181102030126826.png","dkfs":"0","name":"\u50cf\u7d20\u5c0f\u7cbe\u7075","area":""},{"downurl":"\/\/www.99danji.com\/az\/68556\/","thumb":"\/\/img.99danji.com\/uploadfile\/2018\/1102\/20181102031652787.png","dkfs":"0","name":"\u53e3\u888b\u5996\u602a\u65e5\u6708","area":""},{"downurl":"\/\/m.99danji.com\/az\/116674\/","thumb":"\/\/img.99danji.com\/uploadfile\/2018\/0917\/20180917105440417.png","dkfs":"0","name":"\u6697\u9ed1\u65f6\u5149","area":""},{"downurl":"\/\/m.99danji.com\/az\/68556\/","thumb":"\/\/img.99danji.com\/uploadfile\/2018\/0914\/20180914023514966.png","dkfs":"0","name":"\u53e3\u888b\u5996\u602a\u65e5\u6708","area":""},{"downurl":"\/\/m.99danji.com\/az\/122653\/","thumb":"\/\/img.99danji.com\/uploadfile\/2018\/1102\/20181102073356275.png","dkfs":"0","name":"\u53e3\u888b\u5996\u602aAR","area":""},{"downurl":"\/\/m.99danji.com\/az\/128463\/","thumb":"\/\/img.99danji.com\/uploadfile\/2018\/1109\/20181109043739737.png","dkfs":"0","name":"\u4ed9\u5251\u5947\u4fa0\u4f20\u56db","area":""},{"downurl":"\/\/www.99danji.com\/az\/99246\/","thumb":"\/\/img.99danji.com\/uploadfile\/2018\/1109\/20181109043558536.png","dkfs":"0","name":"\u660e\u65e5\u4e4b\u540e","area":""},{"downurl":"\/\/m.99danji.com\/az\/113255\/","thumb":"\/\/img.99danji.com\/uploadfile\/2018\/0914\/20180914023630910.png","dkfs":"0","name":"\u6c99\u57ce\u65e0\u53cc","area":""},{"downurl":"\/\/m.99danji.com\/az\/123563\/","thumb":"\/\/img.99danji.com\/uploadfile\/2018\/1102\/20181102024807770.png","dkfs":"0","name":"\u5168\u6c11\u51a0\u519b\u8db3\u74032018","area":""},{"downurl":"\/\/m.99danji.com\/az\/106785\/","thumb":"\/\/img.99danji.com\/uploadfile\/2018\/0305\/20180305071152285.png","dkfs":"0","name":"\u65e0\u5398\u5996\u5996","area":""}]};
    
			if(datalist.data){
				    var dataNum=datalist.data.length;
				    for(var i=0;i<dataNum;i++){
		                if(datalist.data[i] && datalist.data[i].area!="" && (datalist.data[i].area.indexOf(city)!=-1 || datalist.data[i].area.indexOf(province)!=-1)){
					        datalist.data.splice(i,1);
                            i--;
				        }
                    }
			}
            if(datalist.data){
				dataNum=datalist.data.length;
			}else{
				dataNum=0;
			}			
	 html = "<style>.top-img{height:auto;padding:0 0 5px 0;background:none}.top-img .mod-one li{width:20%;margin:5px 0 0 0}</style><ul class=\"mod-one\">";
	            
			if(dataNum>10){
				dataNum = 10;
			}
			for(var j = 0;j < dataNum;j++){
				datalist.data[j].name = datalist.data[j].name.substring(0,4);
	            html += "<li><a href=\""+datalist.data[j].downurl+"\"><img src=\""+datalist.data[j].thumb+"\"/><span>"+datalist.data[j].name+"</span></a></li>";
	        };
            html += "</ul>";
        document.getElementById('top-img').innerHTML = html;
		})