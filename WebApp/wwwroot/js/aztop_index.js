var datalist = {"data1":[{"downurl":"\/\/m.99danji.com\/az\/102031\/","thumb":"\/\/img.99danji.com\/uploadfile\/2018\/1129\/20181129043359336.png","dkfs":"0","name":"\u68a6\u5e7b\u6a21\u62df\u6218","area":""},{"downurl":"https:\/\/www.99danji.com\/az\/26545\/","thumb":"https:\/\/img.99danji.com\/uploadfile\/2016\/0831\/20160831095304930.jpg","dkfs":"0","name":"\u98ce\u66b4\u90e8\u843d","area":""},{"downurl":"https:\/\/www.99danji.com\/az\/152727\/","thumb":"https:\/\/img.99danji.com\/uploadfile\/2019\/0719\/20190719030256809.png","dkfs":"0","name":"\u6b66\u57233d","area":""},{"downurl":"https:\/\/www.99danji.com\/az\/131867\/","thumb":"https:\/\/img.99danji.com\/uploadfile\/2019\/0104\/20190104015338764.jpg","dkfs":"0","name":"\u65e0\u8d66\u5355\u804c\u4e1a","area":""},{"downurl":"https:\/\/www.99danji.com\/az\/147007\/","thumb":"https:\/\/img.99danji.com\/uploadfile\/2019\/0813\/20190813061333928.jpg","dkfs":"0","name":"\u5927\u519b\u5e08","area":""},{"downurl":"https:\/\/www.99danji.com\/az\/146339\/","thumb":"https:\/\/img.99danji.com\/uploadfile\/2019\/0604\/20190604031924180.png","dkfs":"0","name":"\u5929\u7f5a\u8bc0","area":""},{"downurl":"https:\/\/www.99danji.com\/az\/155623\/","thumb":"https:\/\/img.99danji.com\/uploadfile\/2019\/0812\/20190812113302103.png","dkfs":"0","name":"\u534e\u4f57\u5fc5\u987b\u6b7b","area":""},{"downurl":"https:\/\/m.99danji.com\/az\/25018\/","thumb":"\/\/img.99danji.com\/uploadfile\/2019\/0813\/20190813041221621.png","dkfs":"0","name":"\u6597\u7834\u897f\u6e38","area":""}],"data2":[{"downurl":"\/\/m.99danji.com\/az\/125550\/","thumb":"\/\/img.99danji.com\/uploadfile\/2018\/1129\/20181129045449945.jpg","dkfs":"0","name":"\u9f99\u57ce\u6218\u6b4c","area":""},{"downurl":"https:\/\/www.99danji.com\/az\/115949\/","thumb":"https:\/\/img.99danji.com\/uploadfile\/2019\/0318\/20190318035306624.png","dkfs":"0","name":"\u6700\u4f20\u5947","area":""},{"downurl":"https:\/\/www.99danji.com\/az\/151612\/","thumb":"https:\/\/img.99danji.com\/uploadfile\/2019\/0711\/20190711050824188.png","dkfs":"0","name":"\u8475\u82b1\u70b9\u7a74\u624b","area":""},{"downurl":"https:\/\/www.99danji.com\/az\/150509\/","thumb":"https:\/\/img.99danji.com\/uploadfile\/2019\/0704\/20190704090419320.png","dkfs":"0","name":"\u68a6\u5e7b\u5f52\u6765\u91cd\u751f\u7248","area":""},{"downurl":"https:\/\/www.99danji.com\/az\/155938\/","thumb":"https:\/\/img.99danji.com\/uploadfile\/2019\/0813\/20190813055910728.png","dkfs":"0","name":"\u68a6\u5e7b\u8d44\u6e90\u65e0\u9650\u7248","area":""}]};
    if(/(iPhone|iPad|iPod|iOS)/i.test(navigator.userAgent)){
			var s = "ios";
		}else{
			var s = "az";
		}

		if(sessionStorage.obj1){
            sessionStorage.obj2 = JSON.stringify(datalist.data1);
        }else{
            sessionStorage.obj1 = JSON.stringify(datalist.data1);
        }
		var obj1 = sessionStorage.obj1,
            obj2 = sessionStorage.obj2,
            data_boolean = sessionStorage.obj1===sessionStorage.obj2;

		if(s=="ios"){
			if(data_boolean==false){
				sessionStorage.removeItem("ios");
				if(sessionStorage.obj2) sessionStorage.obj1 = sessionStorage.obj2;				
                sessionStorage.removeItem("obj2");
			}
			if(sessionStorage.ios){
			    datalist.data1 = JSON.parse(sessionStorage.ios);
		    }
		}else{
			if(data_boolean==false){
				sessionStorage.removeItem("az");
				if(sessionStorage.obj2) sessionStorage.obj1 = sessionStorage.obj2;				
                sessionStorage.removeItem("obj2");
			}
			if(sessionStorage.az){
			    datalist.data1 = JSON.parse(sessionStorage.az);
		    }
		}
		
	 html = "<style>::-webkit-scrollbar{display:none;width:0;height:0}.top-img{overflow:hidden;zoom:1;padding:0 0 5px 10px;background: #fff;}.top-img ul{font-size:0;white-space:nowrap;overflow-x:scroll;overflow-y:hidden;}.top-img li{font-size:14px;margin-right:20px;white-space:normal;display:inline-block;width: auto;float:none;}</style><ul class=\"mod-one\">";
	      
			if(datalist.data1){
				var data1Num=datalist.data1.length;
			}else{
				var data1Num=0;
			}
			if(datalist.data2){
				var data2Num=datalist.data2.length;
			}else{
				var data2Num=0;
			}

			if(data1Num>10){
				data1Num = 10;
			}

			for(var j = 0,len1 = data1Num;j < len1;j++){
				datalist.data1[j].name = datalist.data1[j].name.substring(0,4);
	            html += "<li><a href=\""+datalist.data1[j].downurl+"\"><img src=\""+datalist.data1[j].thumb+"\"/><span>"+datalist.data1[j].name+"</span></a></li>";
	        };

			var data2_Num = 10 - data1Num;
			if(data2Num>data2_Num){
				data2Num = data2_Num;
			}
			for(var k = 0,len2 = data2Num;k < len2;k++){
					datalist.data2[k].name = datalist.data2[k].name.substring(0,4);
		            html += "<li><a href=\""+datalist.data2[k].downurl+"\"><img src=\""+datalist.data2[k].thumb+"\"/><span>"+datalist.data2[k].name+"</span></a></li>";
	        };
			if(data1Num>5){
			    var first = datalist.data1.slice(0,5);
				datalist.data1.splice(0,5);
				datalist.data1.concat(first);
				datalist.data1 = datalist.data1.concat(first)
			}
			if(s=="ios"){
				sessionStorage.ios = JSON.stringify(datalist.data1);
			}else{
				sessionStorage.az = JSON.stringify(datalist.data1);
			}

            html += "</ul>";
    document.getElementById('top-img').innerHTML = html;
		