var datalist = {"data1":[{"downurl":"\/\/m.99danji.com\/az\/122679\/","thumb":"\/\/img.99danji.com\/uploadfile\/2018\/1129\/20181129050043943.jpg","dkfs":"0","name":"\u5185\u6db5\u897f\u6e38","area":""},{"downurl":"\/\/m.99danji.com\/az\/71356\/","thumb":"\/\/img.99danji.com\/uploadfile\/2018\/1129\/20181129050946544.jpg","dkfs":"0","name":"\u9b54\u6cd5\u95e8\u91cd\u751f","area":""},{"downurl":"\/\/m.99danji.com\/az\/116392\/","thumb":"\/\/img.99danji.com\/uploadfile\/2018\/1130\/20181130085902683.png","dkfs":"0","name":"\u4ed9\u4fa3\u5947\u7f18","area":""}],"data2":[{"downurl":"\/\/m.99danji.com\/az\/111126\/","thumb":"\/\/img.99danji.com\/uploadfile\/2018\/1129\/20181129050656142.png","dkfs":"0","name":"\u4f5c\u5996\u8ba1","area":""},{"downurl":"\/\/m.99danji.com\/az\/120489\/","thumb":"\/\/img.99danji.com\/uploadfile\/2018\/1129\/20181129070150520.jpg","dkfs":"0","name":"\u521b\u5143\u6218\u8bb0","area":""},{"downurl":"\/\/m.99danji.com\/az\/129697\/","thumb":"\/\/img.99danji.com\/uploadfile\/2018\/1130\/20181130012700620.png","dkfs":"0","name":"\u4e71\u4e16\u7fa4\u96c4","area":""},{"downurl":"\/\/m.99danji.com\/az\/129698\/","thumb":"\/\/img.99danji.com\/uploadfile\/2018\/1204\/20181204031645556.png","dkfs":"0","name":"\u5927\u51b3\u6218","area":""},{"downurl":"\/\/m.99danji.com\/az\/129695\/","thumb":"\/\/img.99danji.com\/uploadfile\/2018\/1206\/20181206091208718.jpg","dkfs":"0","name":"\u6211\u662f\u5927\u77ff\u4e3b","area":""}]};
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
		