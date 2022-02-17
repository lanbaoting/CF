;(function($){
	$(function(){
		var $more = $('.details-more');
		$more.click(function(){
			var _this = $(this);
			_this.toggleClass('more-bg');
			(_this.is('.more-bg'))?_this.text('点击收起更多'):_this.text('点击查看更多');
			$('.details-bd').toggleClass('auto');
		});
		$('.top-bg a').click(function(){
			$('.top-nav').toggle();
		});
	});
})(Zepto);