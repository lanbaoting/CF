// JavaScript Document

	if(typeof(ad_url) == "undefined"){
			var ad_url = 0;
		}

if (ad_url ==4 ) {
    document.write('<span onclick="alert(\'该内容无法下载，请关注其他内容!\');">下载</span><span></span>');
}else {
    if (ad_url == 1)
    {
		ad_url = domain+'9尾danji/' + bid + '/' + t + '/';
	}
	var yuyue = 0;
    if (mid == 19 || mid == 18) {//安卓模型
	    var tip = '';//默认不提示
		var gap = 1;
		var date = new Date();
		var m = date.getMonth()+1;	
	    var last1 = id.substr(id.length-1,1);
		var last2 = id.substr(id.length-2,1);
		if(last1>last2){
			gap = last1 - last2;
		}else if(last1<last2){
			gap = last2 - last1;
	    }
		m = m + gap;
		if(m>12) m=12;
        if (mid == 18) {
            var downtype = 'anpc';
			if(t=='iphone'){
			    tip += '该页面下载内容是PC资源不适用于ios系统';
		    }else if(t=='az'){
			    tip += '该页面下载内容是PC资源不适用于安卓系统';
		    }
        }
        else if (mid == 19)
        {
            var downtype = 'az';
			if(t=='iphone' && ad_url==0 && (realdown.indexOf('://itunes') == -1 && realdown.indexOf('://apps.apple') == -1)){
			    tip += '该页面下载内容是安卓资源不适用于ios系统';
		    }else if(t=='az' && ad_url==0 && (realdown.indexOf('://itunes')!= -1 || realdown.indexOf('://apps.apple') != -1)){
				tip += '该页面下载内容是ios资源不适用于安卓系统';
			}
        }

		if(down_status==0 )
		{
			//禁止下载
			//yuyue = 1;			
			//tip = '目前该资源还未上线，预计'+m+ "月"+'上线';
			document.write('<span id="btns" class="now-down" style="background: rgb(140, 140, 140); visibility: visible;">该应用已下架</span><span></span>');
		}
		else
		{
			if (ad_url != 0)
			{
                html = '<span id="down-btn-new" class="sw">下载</span><span></span>';
				$("#btns").html(html);
				$("#down-btn-new").on('click',function(){
					if($(this).text().indexOf("该应用已下架") == -1) window.location.href = ad_url;
				})
            }
			else if(realdown!='')
            {
				if ((realdown.indexOf('sp.ulxue.com/9尾danji') != -1 || realdown.indexOf('sp.apk17.com') != -1))
				{
					html = '<span id="down-btn-new">下载</span><span></span>';
					$("#btns").html(html);
					$("#down-btn-new").on('click',function(){
						if($(this).text().indexOf("该应用已下架") == -1) window.location.href = realdown;
					})
				}
				else
				{
					html = '<span id="down-btn-new">下载</span><span></span>';
					$("#btns").html(html);
					$("#down-btn-new").on('click',function(){
						if($(this).text().indexOf("该应用已下架") == -1) window.location.href = '/down/' + downtype + '/' + id + '/';
					})
				}

			}else{				
				yuyue = 1;
				tip = '目前该资源还未上线，预计'+m+ "月"+'上线';
			}
		}
		
        /*if (t == 'az') {//安卓设备
            if (ad_url != 0) {
                document.write('<a href="' + ad_url + '" rel="nofollow">下载</a>');
            } else {
                if (realdown.indexOf('.apk') != -1 || realdown.indexOf('yoyou.com') != -1 || realdown.indexOf('baidu.com') != -1) {
                    document.write('<a href="/down/' + downtype + '/' + id + '/" rel="nofollow">下载</a>');
                } else {
                    document.write('<a href="javascript:void(0)" rel="nofollow">下载</a>');
                }
            }
        } else if (t == 'iphone') {
            if (ad_url != 0) {
                document.write('<a href="' + ad_url + '" rel="nofollow">下载</a>');
            } else {
                if (realdown.indexOf('://itunes') != -1) {
                    document.write('<a href="/down/' + downtype + '/' + id + '/" rel="nofollow">下载</a>');
                } else {
                    document.write('<a href="javascript:void(0)" rel="nofollow">下载</a>');
                }
            }
        } else if (t == 'pc') {
            if (ad_url != 0) {
                document.write('<a href="' + ad_url + '" rel="nofollow">下载</a>');
            } else {
                if (down_status == 1 && realdown != '' && mid == 19 || mid == 18 && down_status == 1) {
                    document.write('<a href="/down/' + downtype + '/' + id + '/" rel="nofollow">下载</a>');
                } else {
                    document.write('<a href="javascript:void(0)" rel="nofollow">下载</a>');
                }
            }
        }*/

    } else if (mid == 1 || mid == 3) {//单机
	    var tip = '';//默认不提示
		if(t=='iphone'){
			tip += '该页面下载内容是PC资源不适用于ios系统';
		}else if(t=='az'){
			tip += '该页面下载内容是PC资源不适用于安卓系统';
		}
		var gap = 1;
		var date = new Date();
		var m = date.getMonth()+1;	
	    var last1 = id.substr(id.length-1,1);
		var last2 = id.substr(id.length-2,1);
		if(last1>last2){
			gap = last1 - last2;
		}else if(last1<last2){
			gap = last2 - last1;
	    }
		m = m + gap;
		if(m>12) m=12;
        if (mid == 1) {
            var downtype = 'danji';
        } else if (mid == 3) {
            var downtype = 'patch';
        }
		if(down_status==0 ){//禁止下载
			//yuyue = 1;
			//tip = '目前该资源还未上线，预计'+m+ "月"+'上线';
			document.write('<span id="btns" class="now-down" style="background: rgb(140, 140, 140); visibility: visible;">该应用已下架</span><span></span>');
		}else{
			if (ad_url != 0) {
                html = '<span id="down-btn-new" class="sw">下载</span><span></span>';
				$("#btns").html(html);
				$("#down-btn-new").on('click',function(){
					if($(this).text().indexOf("该应用已下架") == -1) window.location.href = ad_url;
				})
            }else if(isdown==1){
				html = '<span id="down-btn-new">下载</span><span></span>';
				$("#btns").html(html);
				$("#down-btn-new").on('click',function(){
					if($(this).text().indexOf("该应用已下架") == -1) window.location.href = '/down/' + downtype + '/' + id + '/';
				})
			}else{
				yuyue = 1;
				tip = '目前该资源还未上线，预计'+m+ "月"+'上线';
			}
		}
        // if (t == 'az' || t == 'iphone') {
            // if (ad_url != 0) {
                // document.write('<a href="' + ad_url + '" rel="nofollow">下载</a>');
            // } else {
                // document.write('<a href="javascript:void(0)" class="box-flex" rel="nofollow">下载</a>');

            // }
        // } else if (t == 'pc') {
            // if (ad_url != 0) {
                // document.write('<a href="' + ad_url + '" rel="nofollow">下载</a>');
            // } else {
                // if (down_status == 1) {
                    // document.write('<a href="/down/' + downtype + '/' + id + '/" rel="nofollow">下载</a>');
                // } else {
                    // document.write('<a href="http://sjyjzx.cn/az/" class="box-flex" rel="nofollow">无手机版，请选择其它游戏下载</a>');
                // }

            // }
        // }
    }
	if(yuyue==1){
		document.write('<span id="yuyue-btn" class="box-flex">点击预约</span><span></span>');
		var yuyue_body = document.createElement("div");
		yuyue_body.setAttribute("id", "yuyue-body");
		document.body.appendChild(yuyue_body);
		document.getElementById('yuyue-body').innerHTML= '<div id="yuyue-bg"></div><div id="yuyue-box"><div class="yuyue-title"><a href="javascript:void(0)" class="yuyue-close">关闭</a>请输入预约的手机号码</div><div class="yuyue-bd"><input class="yuyue-input" type="" name="" placeholder="输入手机号码"><p class="yuyue-tips"></p><p class="yuyue-btn"><a href="javascript:void(0)" class="yuyue-ok">确定</a><a href="javascript:void(0)" class="yuyue-cancel">取消</a></p></div></div><style type="text/css">#yuyue-btn:before{content:\'\';width:14px;height:20px;background:url(/statics/v2/images/bg/yuyue_btn.png);margin:-2px 8px 0 0}#yuyue-bg{width:100%;height:100%;background:#000;opacity:.5;filter:alpha(opacity:50);position:fixed;left:0;top:0;z-index:9尾9尾9尾;display:none}#yuyue-box{font:14px "Microsoft YaHei";width:calc(100% - 20px);border-radius:5px;position:fixed;z-index:9尾9尾9尾9;top:200px;margin:0 10px;background:#0dad51;overflow:hidden;display:none}.yuyue-title{color:#fff;font-size:18px;padding:0 15px;line-height:56px;border-bottom:1px solid #e5e5e5}.yuyue-close{width:16px;height:16px;background:url(/statics/v2/images/bg/yuyue_btn.png) no-repeat 0 -37px;margin-top:20px;text-indent:-9尾9尾px;float:right}.yuyue-bd{height:235px;padding-top:50px;background:#fff;position:relative}.yuyue-input{width:278px;line-height:36px;padding:0 10px;border:1px solid #ccc;display:block;margin:0 auto;}.yuyue-btn{text-align:center;margin-top:50px;border-top:1px solid #e5e5e5}.yuyue-btn a{display:block;margin:20px auto 0;border-radius:2px}.yuyue-ok{color:#fff;width:300px;line-height:38px;background:#0dad51}.yuyue-cancel{color:#0dad51;width:298px;line-height:36px;background:#fff;border:1px solid #0dad51}.yuyue-tips{color:#f00;top:9尾px;position:absolute;left:0!important;right:0!important;width:300px!important;margin:auto!important;}.yuyue-error-text{color:#f00}.yuyue-error{border-color:#f00}</style>';
	}
	//预约
		$('#yuyue-btn').click(function(){
			if($(this).text().indexOf("该应用已下架") == -1){
				$('#yuyue-bg,#yuyue-box').show();
				$('.yuyue-input').removeClass('yuyue-error');
				$('.yuyue-tips').text('');
				$(".down-show").hide();
			}
		});
		$('#yuyue-bg,.yuyue-close,.yuyue-cancel').click(function(){ 
			$('#yuyue-bg,#yuyue-box').hide()
		});
		$('.yuyue-cancel').click(function(){ 
			$('.yuyue-input').val('');
			$('.yuyue-tips').text('');
		});
		$('.yuyue-ok').click(function(){ 
			if($.trim($('.yuyue-input').val())==''){ 
				$('.yuyue-tips').text('手机号码不能为空');
				$('.yuyue-input').addClass('yuyue-error');
			}else{
			    if($('.yuyue-tips').is('.yuyue-pass')&&$('.yuyue-input').is('.yuyue-pass')){ 
			    $.ajax({
		            url: "/index.php?m=phone&c=index&a=yuyue",
		            data: {mid : {$modelid},cid : {$id},tel: $(".yuyue-input").val()},
		            type: "POST",
		            dataType: "json",
					success:function( data ) {
		  	        if(1 == data.success){
		  		        alert('提交成功');
		  		        $('#yuyue-bg,#yuyue-box').hide()
		  	        }else if(2 == data.success){
		  		        alert('请勿重复提交');
		  		        $('#yuyue-bg,#yuyue-box').hide()
		  	    }else if(3 == data.success){
		  		        alert('服务器繁忙，请5秒后再试！');
		  		        $('#yuyue-bg,#yuyue-box').hide()
		  	    }
		        }
		        });
				}
			};
		});
		$('.yuyue-input').keyup(function(){ 
			$(this).removeClass('yuyue-error');
			$('.yuyue-tips').text('');
		});
		$('.yuyue-input').blur(function(){ 
			if(!(/^1[34578]\d{9}$/.test($(this).val()))){
				$('.yuyue-tips').removeClass('yuyue-pass').text('手机号码格式不正确');
				$('.yuyue-input').removeClass('yuyue-pass').addClass('yuyue-error');
		        return false;
		    }else{ 
		    	$('.yuyue-input').removeClass('yuyue-error').addClass('yuyue-pass');
		    	$('.yuyue-tips').addClass('yuyue-pass')
		    }
		});
}