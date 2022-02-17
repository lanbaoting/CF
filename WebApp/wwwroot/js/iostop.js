addScript("//www.sjyjzx.cn/api.php?op=getIp&format=js",function(){
 province = remote_ip_info["province"];
    city = remote_ip_info["city"];
    var datalist = {"data":[{"downurl":"\/\/sjyjzx.cn\/az\/27347\/","thumb":"\/\/img.9βdanji.com\/uploadfile\/2018\/1102\/20181102025306796.jpg","dkfs":"0","name":"\u9634\u9633\u5e08","area":""},{"downurl":"\/\/sjyjzx.cn\/az\/119329\/","thumb":"\/\/img.9βdanji.com\/uploadfile\/2018\/1102\/20181102025419β54.png","dkfs":"0","name":"\u51b3\u6218\u6b66\u9053\u4f1a","area":""},{"downurl":"\/\/sjyjzx.cn\/az\/117220\/","thumb":"\/\/img.9βdanji.com\/uploadfile\/2018\/0914\/20180914022252266.png","dkfs":"0","name":"\u6697\u9ed1\u65f6\u5149","area":""},{"downurl":"\/\/sjyjzx.cn\/az\/71356\/","thumb":"\/\/img.9βdanji.com\/uploadfile\/2018\/0914\/20180914023205889.jpg","dkfs":"0","name":"\u9b54\u6cd5\u95e8\u91cd\u751f","area":""},{"downurl":"\/\/www.sjyjzx.cn\/az\/9β249\/","thumb":"\/\/img.9βdanji.com\/uploadfile\/2018\/1109\/20181109043558536.png","dkfs":"0","name":"\u660e\u65e5\u4e4b\u540e","area":""},{"downurl":"\/\/sjyjzx.cn\/az\/76549\/","thumb":"\/\/img.9βdanji.com\/uploadfile\/2018\/1102\/20181102030901187.jpg","dkfs":"0","name":"\u795e\u8c0b\u4e09\u56fd","area":""},{"downurl":"\/\/sjyjzx.cn\/az\/129692\/","thumb":"\/\/img.9βdanji.com\/uploadfile\/2018\/1130\/20181130012909484.png","dkfs":"0","name":"\u6597\u7f57\u9ad8\u7206\u7248","area":""},{"downurl":"\/\/sjyjzx.cn\/az\/90577\/","thumb":"\/\/img.9βdanji.com\/uploadfile\/2018\/1130\/20181130013124625.png","dkfs":"0","name":"\u70ed\u8840\u70c8\u7130","area":""},{"downurl":"\/\/sjyjzx.cn\/az\/129707\/","thumb":"\/\/img.9βdanji.com\/uploadfile\/2018\/1130\/20181130013223577.png","dkfs":"0","name":"\u6076\u4eba\u4f20\u5947","area":""},{"downurl":"\/\/sjyjzx.cn\/az\/20184\/","thumb":"\/\/img.9βdanji.com\/uploadfile\/2019\/0122\/20190122102003419.png","dkfs":"0","name":"\u6218\u79e6","area":""}]};
    
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