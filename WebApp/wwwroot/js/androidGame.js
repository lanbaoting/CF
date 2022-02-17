function addScript(t, e, n) {
	var i = document.createElement("script");
	i.setAttribute("type", "text/javascript"),
		i.src = t,
		i.addEventListener ? i.addEventListener("load",
			function () {
				"function" == typeof e && e()
			},
			!1) : i.attachEvent && i.attachEvent("onreadystatechange",
				function () {
					"loaded" == window.event.srcElement.readyState && "function" == typeof e && e()
				}),
		void 0 !== n ? document.getElementById(n).appendChild(i) : document.getElementsByTagName("head")[0].appendChild(i)
}
var Zepto = function () {
	function t(t) {
		return null == t ? String(t) : B[q.call(t)] || "object"
	}
	function e(e) {
		return "function" == t(e)
	}
	function n(t) {
		return null != t && t == t.window
	}
	function i(t) {
		return null != t && t.nodeType == t.DOCUMENT_NODE
	}
	function r(e) {
		return "object" == t(e)
	}
	function o(t) {
		return r(t) && !n(t) && Object.getPrototypeOf(t) == Object.prototype
	}
	function a(t) {
		return "number" == typeof t.length
	}
	function s(t) {
		return t.length > 0 ? w.fn.concat.apply([], t) : t
	}
	function c(t) {
		return t.replace(/::/g, "/").replace(/([A-Z]+)([A-Z][a-z])/g, "$1_$2").replace(/([a-z\d])([A-Z])/g, "$1_$2").replace(/_/g, "-").toLowerCase()
	}
	function l(t) {
		return t in P ? P[t] : P[t] = new RegExp("(^|\\s)" + t + "(\\s|$)")
	}
	function u(t, e) {
		return "number" != typeof e || O[c(t)] ? e : e + "px"
	}
	function f(t) {
		return "children" in t ? S.call(t.children) : w.map(t.childNodes,
			function (t) {
				return 1 == t.nodeType ? t : void 0
			})
	}
	function p(t, e, n) {
		for (x in e) n && (o(e[x]) || U(e[x])) ? (o(e[x]) && !o(t[x]) && (t[x] = {}), U(e[x]) && !U(t[x]) && (t[x] = []), p(t[x], e[x], n)) : e[x] !== b && (t[x] = e[x])
	}
	function h(t, e) {
		return null == e ? w(t) : w(t).filter(e)
	}
	function d(t, n, i, r) {
		return e(n) ? n.call(t, i, r) : n
	}
	function m(t, e, n) {
		null == n ? t.removeAttribute(e) : t.setAttribute(e, n)
	}
	function g(t, e) {
		var n = t.className,
			i = n && n.baseVal !== b;
		return e === b ? i ? n.baseVal : n : void (i ? n.baseVal = e : t.className = e)
	}
	function v(t) {
		var e;
		try {
			return t ? "true" == t || "false" != t && ("null" == t ? null : /^0/.test(t) || isNaN(e = Number(t)) ? /^[\[\{]/.test(t) ? w.parseJSON(t) : t : e) : t
		} catch (e) {
			return t
		}
	}
	function y(t, e) {
		e(t);
		for (var n = 0,
			i = t.childNodes.length; i > n; n++) y(t.childNodes[n], e)
	}
	var b, x, w, T, C, E, N = [],
		S = N.slice,
		j = N.filter,
		L = window.document,
		k = {},
		P = {},
		O = {
			"column-count": 1,
			columns: 1,
			"font-weight": 1,
			"line-height": 1,
			opacity: 1,
			"z-index": 1,
			zoom: 1
		},
		z = /^\s*<(\w+|!)[^>]*>/,
		A = /^<(\w+)\s*\/?>(?:<\/\1>|)$/,
		F = /<(?!area|br|col|embed|hr|img|input|link|meta|param)(([\w:]+)[^>]*)\/>/gi,
		M = /^(?:body|html)$/i,
		D = /([A-Z])/g,
		$ = ["val", "css", "html", "text", "data", "width", "height", "offset"],
		I = L.createElement("table"),
		Z = L.createElement("tr"),
		R = {
			tr: L.createElement("tbody"),
			tbody: I,
			thead: I,
			tfoot: I,
			td: Z,
			th: Z,
			"*": L.createElement("div")
		},
		H = /complete|loaded|interactive/,
		_ = /^[\w-]*$/,
		B = {},
		q = B.toString,
		W = {},
		V = L.createElement("div"),
		X = {
			tabindex: "tabIndex",
			readonly: "readOnly",
			for: "htmlFor",
			class: "className",
			maxlength: "maxLength",
			cellspacing: "cellSpacing",
			cellpadding: "cellPadding",
			rowspan: "rowSpan",
			colspan: "colSpan",
			usemap: "useMap",
			frameborder: "frameBorder",
			contenteditable: "contentEditable"
		},
		U = Array.isArray ||
			function (t) {
				return t instanceof Array
			};
	return W.matches = function (t, e) {
		if (!e || !t || 1 !== t.nodeType) return !1;
		var n = t.webkitMatchesSelector || t.mozMatchesSelector || t.oMatchesSelector || t.matchesSelector;
		if (n) return n.call(t, e);
		var i, r = t.parentNode,
			o = !r;
		return o && (r = V).appendChild(t),
			i = ~W.qsa(r, e).indexOf(t),
			o && V.removeChild(t),
			i
	},
		C = function (t) {
			return t.replace(/-+(.)?/g,
				function (t, e) {
					return e ? e.toUpperCase() : ""
				})
		},
		E = function (t) {
			return j.call(t,
				function (e, n) {
					return t.indexOf(e) == n
				})
		},
		W.fragment = function (t, e, n) {
			var i, r, a;
			return A.test(t) && (i = w(L.createElement(RegExp.$1))),
				i || (t.replace && (t = t.replace(F, "<$1></$2>")), e === b && (e = z.test(t) && RegExp.$1), e in R || (e = "*"), a = R[e], a.innerHTML = "" + t, i = w.each(S.call(a.childNodes),
					function () {
						a.removeChild(this)
					})),
				o(n) && (r = w(i), w.each(n,
					function (t, e) {
						$.indexOf(t) > -1 ? r[t](e) : r.attr(t, e)
					})),
				i
		},
		W.Z = function (t, e) {
			return t = t || [],
				t.__proto__ = w.fn,
				t.selector = e || "",
				t
		},
		W.isZ = function (t) {
			return t instanceof W.Z
		},
		W.init = function (t, n) {
			var i;
			if (!t) return W.Z();
			if ("string" == typeof t) if ("<" == (t = t.trim())[0] && z.test(t)) i = W.fragment(t, RegExp.$1, n),
				t = null;
			else {
				if (n !== b) return w(n).find(t);
				i = W.qsa(L, t)
			} else {
				if (e(t)) return w(L).ready(t);
				if (W.isZ(t)) return t;
				if (U(t)) i = function (t) {
					return j.call(t,
						function (t) {
							return null != t
						})
				}(t);
				else if (r(t)) i = [t],
					t = null;
				else if (z.test(t)) i = W.fragment(t.trim(), RegExp.$1, n),
					t = null;
				else {
					if (n !== b) return w(n).find(t);
					i = W.qsa(L, t)
				}
			}
			return W.Z(i, t)
		},
		w = function (t, e) {
			return W.init(t, e)
		},
		w.extend = function (t) {
			var e, n = S.call(arguments, 1);
			return "boolean" == typeof t && (e = t, t = n.shift()),
				n.forEach(function (n) {
					p(t, n, e)
				}),
				t
		},
		W.qsa = function (t, e) {
			var n, r = "#" == e[0],
				o = !r && "." == e[0],
				a = r || o ? e.slice(1) : e,
				s = _.test(a);
			return i(t) && s && r ? (n = t.getElementById(a)) ? [n] : [] : 1 !== t.nodeType && 9 !== t.nodeType ? [] : S.call(s && !r ? o ? t.getElementsByClassName(a) : t.getElementsByTagName(e) : t.querySelectorAll(e))
		},
		w.contains = L.documentElement.contains ?
			function (t, e) {
				return t !== e && t.contains(e)
			} : function (t, e) {
				for (; e && (e = e.parentNode);) if (e === t) return !0;
				return !1
			},
		w.type = t,
		w.isFunction = e,
		w.isWindow = n,
		w.isArray = U,
		w.isPlainObject = o,
		w.isEmptyObject = function (t) {
			var e;
			for (e in t) return !1;
			return !0
		},
		w.inArray = function (t, e, n) {
			return N.indexOf.call(e, t, n)
		},
		w.camelCase = C,
		w.trim = function (t) {
			return null == t ? "" : String.prototype.trim.call(t)
		},
		w.uuid = 0,
		w.support = {},
		w.expr = {},
		w.map = function (t, e) {
			var n, i, r, o = [];
			if (a(t)) for (i = 0; i < t.length; i++) null != (n = e(t[i], i)) && o.push(n);
			else for (r in t) null != (n = e(t[r], r)) && o.push(n);
			return s(o)
		},
		w.each = function (t, e) {
			var n, i;
			if (a(t)) {
				for (n = 0; n < t.length; n++) if (!1 === e.call(t[n], n, t[n])) return t
			} else for (i in t) if (!1 === e.call(t[i], i, t[i])) return t;
			return t
		},
		w.grep = function (t, e) {
			return j.call(t, e)
		},
		window.JSON && (w.parseJSON = JSON.parse),
		w.each("Boolean Number String Function Array Date RegExp Object Error".split(" "),
			function (t, e) {
				B["[object " + e + "]"] = e.toLowerCase()
			}),
		w.fn = {
			forEach: N.forEach,
			reduce: N.reduce,
			push: N.push,
			sort: N.sort,
			indexOf: N.indexOf,
			concat: N.concat,
			map: function (t) {
				return w(w.map(this,
					function (e, n) {
						return t.call(e, n, e)
					}))
			},
			slice: function () {
				return w(S.apply(this, arguments))
			},
			ready: function (t) {
				return H.test(L.readyState) && L.body ? t(w) : L.addEventListener("DOMContentLoaded",
					function () {
						t(w)
					},
					!1),
					this
			},
			get: function (t) {
				return t === b ? S.call(this) : this[t >= 0 ? t : t + this.length]
			},
			toArray: function () {
				return this.get()
			},
			size: function () {
				return this.length
			},
			remove: function () {
				return this.each(function () {
					null != this.parentNode && this.parentNode.removeChild(this)
				})
			},
			each: function (t) {
				return N.every.call(this,
					function (e, n) {
						return !1 !== t.call(e, n, e)
					}),
					this
			},
			filter: function (t) {
				return e(t) ? this.not(this.not(t)) : w(j.call(this,
					function (e) {
						return W.matches(e, t)
					}))
			},
			add: function (t, e) {
				return w(E(this.concat(w(t, e))))
			},
			is: function (t) {
				return this.length > 0 && W.matches(this[0], t)
			},
			not: function (t) {
				var n = [];
				if (e(t) && t.call !== b) this.each(function (e) {
					t.call(this, e) || n.push(this)
				});
				else {
					var i = "string" == typeof t ? this.filter(t) : a(t) && e(t.item) ? S.call(t) : w(t);
					this.forEach(function (t) {
						i.indexOf(t) < 0 && n.push(t)
					})
				}
				return w(n)
			},
			has: function (t) {
				return this.filter(function () {
					return r(t) ? w.contains(this, t) : w(this).find(t).size()
				})
			},
			eq: function (t) {
				return - 1 === t ? this.slice(t) : this.slice(t, +t + 1)
			},
			first: function () {
				var t = this[0];
				return t && !r(t) ? t : w(t)
			},
			last: function () {
				var t = this[this.length - 1];
				return t && !r(t) ? t : w(t)
			},
			find: function (t) {
				var e = this;
				return t ? "object" == typeof t ? w(t).filter(function () {
					var t = this;
					return N.some.call(e,
						function (e) {
							return w.contains(e, t)
						})
				}) : 1 == this.length ? w(W.qsa(this[0], t)) : this.map(function () {
					return W.qsa(this, t)
				}) : []
			},
			closest: function (t, e) {
				var n = this[0],
					r = !1;
				for ("object" == typeof t && (r = w(t)); n && !(r ? r.indexOf(n) >= 0 : W.matches(n, t));) n = n !== e && !i(n) && n.parentNode;
				return w(n)
			},
			parents: function (t) {
				for (var e = [], n = this; n.length > 0;) n = w.map(n,
					function (t) {
						return (t = t.parentNode) && !i(t) && e.indexOf(t) < 0 ? (e.push(t), t) : void 0
					});
				return h(e, t)
			},
			parent: function (t) {
				return h(E(this.pluck("parentNode")), t)
			},
			children: function (t) {
				return h(this.map(function () {
					return f(this)
				}), t)
			},
			contents: function () {
				return this.map(function () {
					return S.call(this.childNodes)
				})
			},
			siblings: function (t) {
				return h(this.map(function (t, e) {
					return j.call(f(e.parentNode),
						function (t) {
							return t !== e
						})
				}), t)
			},
			empty: function () {
				return this.each(function () {
					this.innerHTML = ""
				})
			},
			pluck: function (t) {
				return w.map(this,
					function (e) {
						return e[t]
					})
			},
			show: function () {
				return this.each(function () {
					"none" == this.style.display && (this.style.display = ""),
						"none" == getComputedStyle(this, "").getPropertyValue("display") && (this.style.display = function (t) {
							var e, n;
							return k[t] || (e = L.createElement(t), L.body.appendChild(e), n = getComputedStyle(e, "").getPropertyValue("display"), e.parentNode.removeChild(e), "none" == n && (n = "block"), k[t] = n),
								k[t]
						}(this.nodeName))
				})
			},
			replaceWith: function (t) {
				return this.before(t).remove()
			},
			wrap: function (t) {
				var n = e(t);
				if (this[0] && !n) var i = w(t).get(0),
					r = i.parentNode || this.length > 1;
				return this.each(function (e) {
					w(this).wrapAll(n ? t.call(this, e) : r ? i.cloneNode(!0) : i)
				})
			},
			wrapAll: function (t) {
				if (this[0]) {
					w(this[0]).before(t = w(t));
					for (var e; (e = t.children()).length;) t = e.first();
					w(t).append(this)
				}
				return this
			},
			wrapInner: function (t) {
				var n = e(t);
				return this.each(function (e) {
					var i = w(this),
						r = i.contents(),
						o = n ? t.call(this, e) : t;
					r.length ? r.wrapAll(o) : i.append(o)
				})
			},
			unwrap: function () {
				return this.parent().each(function () {
					w(this).replaceWith(w(this).children())
				}),
					this
			},
			clone: function () {
				return this.map(function () {
					return this.cloneNode(!0)
				})
			},
			hide: function () {
				return this.css("display", "none")
			},
			toggle: function (t) {
				return this.each(function () {
					var e = w(this); (t === b ? "none" == e.css("display") : t) ? e.show() : e.hide()
				})
			},
			prev: function (t) {
				return w(this.pluck("previousElementSibling")).filter(t || "*")
			},
			next: function (t) {
				return w(this.pluck("nextElementSibling")).filter(t || "*")
			},
			html: function (t) {
				return 0 in arguments ? this.each(function (e) {
					var n = this.innerHTML;
					w(this).empty().append(d(this, t, e, n))
				}) : 0 in this ? this[0].innerHTML : null
			},
			text: function (t) {
				return 0 in arguments ? this.each(function (e) {
					var n = d(this, t, e, this.textContent);
					this.textContent = null == n ? "" : "" + n
				}) : 0 in this ? this[0].textContent : null
			},
			attr: function (t, e) {
				var n;
				return "string" != typeof t || 1 in arguments ? this.each(function (n) {
					if (1 === this.nodeType) if (r(t)) for (x in t) m(this, x, t[x]);
					else m(this, t, d(this, e, n, this.getAttribute(t)))
				}) : this.length && 1 === this[0].nodeType ? !(n = this[0].getAttribute(t)) && t in this[0] ? this[0][t] : n : b
			},
			removeAttr: function (t) {
				return this.each(function () {
					1 === this.nodeType && m(this, t)
				})
			},
			prop: function (t, e) {
				return t = X[t] || t,
					1 in arguments ? this.each(function (n) {
						this[t] = d(this, e, n, this[t])
					}) : this[0] && this[0][t]
			},
			data: function (t, e) {
				var n = "data-" + t.replace(D, "-$1").toLowerCase(),
					i = 1 in arguments ? this.attr(n, e) : this.attr(n);
				return null !== i ? v(i) : b
			},
			val: function (t) {
				return 0 in arguments ? this.each(function (e) {
					this.value = d(this, t, e, this.value)
				}) : this[0] && (this[0].multiple ? w(this[0]).find("option").filter(function () {
					return this.selected
				}).pluck("value") : this[0].value)
			},
			offset: function (t) {
				if (t) return this.each(function (e) {
					var n = w(this),
						i = d(this, t, e, n.offset()),
						r = n.offsetParent().offset(),
						o = {
							top: i.top - r.top,
							left: i.left - r.left
						};
					"static" == n.css("position") && (o.position = "relative"),
						n.css(o)
				});
				if (!this.length) return null;
				var e = this[0].getBoundingClientRect();
				return {
					left: e.left + window.pageXOffset,
					top: e.top + window.pageYOffset,
					width: Math.round(e.width),
					height: Math.round(e.height)
				}
			},
			css: function (e, n) {
				if (arguments.length < 2) {
					var i = this[0],
						r = getComputedStyle(i, "");
					if (!i) return;
					if ("string" == typeof e) return i.style[C(e)] || r.getPropertyValue(e);
					if (U(e)) {
						var o = {};
						return w.each(U(e) ? e : [e],
							function (t, e) {
								o[e] = i.style[C(e)] || r.getPropertyValue(e)
							}),
							o
					}
				}
				var a = "";
				if ("string" == t(e)) n || 0 === n ? a = c(e) + ":" + u(e, n) : this.each(function () {
					this.style.removeProperty(c(e))
				});
				else for (x in e) e[x] || 0 === e[x] ? a += c(x) + ":" + u(x, e[x]) + ";" : this.each(function () {
					this.style.removeProperty(c(x))
				});
				return this.each(function () {
					this.style.cssText += ";" + a
				})
			},
			index: function (t) {
				return t ? this.indexOf(w(t)[0]) : this.parent().children().indexOf(this[0])
			},
			hasClass: function (t) {
				return !!t && N.some.call(this,
					function (t) {
						return this.test(g(t))
					},
					l(t))
			},
			addClass: function (t) {
				return t ? this.each(function (e) {
					T = [];
					var n = g(this);
					d(this, t, e, n).split(/\s+/g).forEach(function (t) {
						w(this).hasClass(t) || T.push(t)
					},
						this),
						T.length && g(this, n + (n ? " " : "") + T.join(" "))
				}) : this
			},
			removeClass: function (t) {
				return this.each(function (e) {
					return t === b ? g(this, "") : (T = g(this), d(this, t, e, T).split(/\s+/g).forEach(function (t) {
						T = T.replace(l(t), " ")
					}), void g(this, T.trim()))
				})
			},
			toggleClass: function (t, e) {
				return t ? this.each(function (n) {
					var i = w(this);
					d(this, t, n, g(this)).split(/\s+/g).forEach(function (t) {
						(e === b ? !i.hasClass(t) : e) ? i.addClass(t) : i.removeClass(t)
					})
				}) : this
			},
			scrollTop: function (t) {
				if (this.length) {
					var e = "scrollTop" in this[0];
					return t === b ? e ? this[0].scrollTop : this[0].pageYOffset : this.each(e ?
						function () {
							this.scrollTop = t
						} : function () {
							this.scrollTo(this.scrollX, t)
						})
				}
			},
			scrollLeft: function (t) {
				if (this.length) {
					var e = "scrollLeft" in this[0];
					return t === b ? e ? this[0].scrollLeft : this[0].pageXOffset : this.each(e ?
						function () {
							this.scrollLeft = t
						} : function () {
							this.scrollTo(t, this.scrollY)
						})
				}
			},
			position: function () {
				if (this.length) {
					var t = this[0],
						e = this.offsetParent(),
						n = this.offset(),
						i = M.test(e[0].nodeName) ? {
							top: 0,
							left: 0
						} : e.offset();
					return n.top -= parseFloat(w(t).css("margin-top")) || 0,
						n.left -= parseFloat(w(t).css("margin-left")) || 0,
						i.top += parseFloat(w(e[0]).css("border-top-width")) || 0,
						i.left += parseFloat(w(e[0]).css("border-left-width")) || 0,
					{
						top: n.top - i.top,
						left: n.left - i.left
					}
				}
			},
			offsetParent: function () {
				return this.map(function () {
					for (var t = this.offsetParent || L.body; t && !M.test(t.nodeName) && "static" == w(t).css("position");) t = t.offsetParent;
					return t
				})
			}
		},
		w.fn.detach = w.fn.remove,
		["width", "height"].forEach(function (t) {
			var e = t.replace(/./,
				function (t) {
					return t[0].toUpperCase()
				});
			w.fn[t] = function (r) {
				var o, a = this[0];
				return r === b ? n(a) ? a["inner" + e] : i(a) ? a.documentElement["scroll" + e] : (o = this.offset()) && o[t] : this.each(function (e) {
					(a = w(this)).css(t, d(this, r, e, a[t]()))
				})
			}
		}),
		["after", "prepend", "before", "append"].forEach(function (e, n) {
			var i = n % 2;
			w.fn[e] = function () {
				var e, r, o = w.map(arguments,
					function (n) {
						return "object" == (e = t(n)) || "array" == e || null == n ? n : W.fragment(n)
					}),
					a = this.length > 1;
				return o.length < 1 ? this : this.each(function (t, e) {
					r = i ? e : e.parentNode,
						e = 0 == n ? e.nextSibling : 1 == n ? e.firstChild : 2 == n ? e : null;
					var s = w.contains(L.documentElement, r);
					o.forEach(function (t) {
						if (a) t = t.cloneNode(!0);
						else if (!r) return w(t).remove();
						r.insertBefore(t, e),
							s && y(t,
								function (t) {
									null == t.nodeName || "SCRIPT" !== t.nodeName.toUpperCase() || t.type && "text/javascript" !== t.type || t.src || window.eval.call(window, t.innerHTML)
								})
					})
				})
			},
				w.fn[i ? e + "To" : "insert" + (n ? "Before" : "After")] = function (t) {
					return w(t)[e](this),
						this
				}
		}),
		W.Z.prototype = w.fn,
		W.uniq = E,
		W.deserializeValue = v,
		w.zepto = W,
		w
}();
window.Zepto = Zepto,
	void 0 === window.$ && (window.$ = Zepto),
	function (t) {
		function e(t) {
			return t._zid || (t._zid = f++)
		}
		function n(t, n, r, o) {
			if ((n = i(n)).ns) var a = function (t) {
				return new RegExp("(?:^| )" + t.replace(" ", " .* ?") + "(?: |$)")
			}(n.ns);
			return (m[e(t)] || []).filter(function (t) {
				return !(!t || n.e && t.e != n.e || n.ns && !a.test(t.ns) || r && e(t.fn) !== e(r) || o && t.sel != o)
			})
		}
		function i(t) {
			var e = ("" + t).split(".");
			return {
				e: e[0],
				ns: e.slice(1).sort().join(" ")
			}
		}
		function r(t, e) {
			return t.del && !v && t.e in y || !!e
		}
		function o(t) {
			return b[t] || v && y[t] || t
		}
		function a(n, a, s, l, f, p, h) {
			var d = e(n),
				g = m[d] || (m[d] = []);
			a.split(/\s/).forEach(function (e) {
				if ("ready" == e) return t(document).ready(s);
				var a = i(e);
				a.fn = s,
					a.sel = f,
					a.e in b && (s = function (e) {
						var n = e.relatedTarget;
						return !n || n !== this && !t.contains(this, n) ? a.fn.apply(this, arguments) : void 0
					}),
					a.del = p;
				var d = p || s;
				a.proxy = function (t) {
					if (!(t = c(t)).isImmediatePropagationStopped()) {
						t.data = l;
						var e = d.apply(n, t._args == u ? [t] : [t].concat(t._args));
						return !1 === e && (t.preventDefault(), t.stopPropagation()),
							e
					}
				},
					a.i = g.length,
					g.push(a),
					"addEventListener" in n && n.addEventListener(o(a.e), a.proxy, r(a, h))
			})
		}
		function s(t, i, a, s, c) {
			var l = e(t); (i || "").split(/\s/).forEach(function (e) {
				n(t, e, a, s).forEach(function (e) {
					delete m[l][e.i],
						"removeEventListener" in t && t.removeEventListener(o(e.e), e.proxy, r(e, c))
				})
			})
		}
		function c(e, n) {
			return (n || !e.isDefaultPrevented) && (n || (n = e), t.each(C,
				function (t, i) {
					var r = n[t];
					e[t] = function () {
						return this[i] = x,
							r && r.apply(n, arguments)
					},
						e[i] = w
				}), (n.defaultPrevented !== u ? n.defaultPrevented : "returnValue" in n ? !1 === n.returnValue : n.getPreventDefault && n.getPreventDefault()) && (e.isDefaultPrevented = x)),
				e
		}
		function l(t) {
			var e, n = {
				originalEvent: t
			};
			for (e in t) T.test(e) || t[e] === u || (n[e] = t[e]);
			return c(n, t)
		}
		var u, f = 1,
			p = Array.prototype.slice,
			h = t.isFunction,
			d = function (t) {
				return "string" == typeof t
			},
			m = {},
			g = {},
			v = "onfocusin" in window,
			y = {
				focus: "focusin",
				blur: "focusout"
			},
			b = {
				mouseenter: "mouseover",
				mouseleave: "mouseout"
			};
		g.click = g.mousedown = g.mouseup = g.mousemove = "MouseEvents",
			t.event = {
				add: a,
				remove: s
			},
			t.proxy = function (n, i) {
				var r = 2 in arguments && p.call(arguments, 2);
				if (h(n)) {
					var o = function () {
						return n.apply(i, r ? r.concat(p.call(arguments)) : arguments)
					};
					return o._zid = e(n),
						o
				}
				if (d(i)) return r ? (r.unshift(n[i], n), t.proxy.apply(null, r)) : t.proxy(n[i], n);
				throw new TypeError("expected function")
			},
			t.fn.bind = function (t, e, n) {
				return this.on(t, e, n)
			},
			t.fn.unbind = function (t, e) {
				return this.off(t, e)
			},
			t.fn.one = function (t, e, n, i) {
				return this.on(t, e, n, i, 1)
			};
		var x = function () {
			return !0
		},
			w = function () {
				return !1
			},
			T = /^([A-Z]|returnValue$|layer[XY]$)/,
			C = {
				preventDefault: "isDefaultPrevented",
				stopImmediatePropagation: "isImmediatePropagationStopped",
				stopPropagation: "isPropagationStopped"
			};
		t.fn.delegate = function (t, e, n) {
			return this.on(e, t, n)
		},
			t.fn.undelegate = function (t, e, n) {
				return this.off(e, t, n)
			},
			t.fn.live = function (e, n) {
				return t(document.body).delegate(this.selector, e, n),
					this
			},
			t.fn.die = function (e, n) {
				return t(document.body).undelegate(this.selector, e, n),
					this
			},
			t.fn.on = function (e, n, i, r, o) {
				var c, f, m = this;
				return e && !d(e) ? (t.each(e,
					function (t, e) {
						m.on(t, n, i, e, o)
					}), m) : (d(n) || h(r) || !1 === r || (r = i, i = n, n = u), (h(i) || !1 === i) && (r = i, i = u), !1 === r && (r = w), m.each(function (u, h) {
						o && (c = function (t) {
							return s(h, t.type, r),
								r.apply(this, arguments)
						}),
							n && (f = function (e) {
								var i, o = t(e.target).closest(n, h).get(0);
								return o && o !== h ? (i = t.extend(l(e), {
									currentTarget: o,
									liveFired: h
								}), (c || r).apply(o, [i].concat(p.call(arguments, 1)))) : void 0
							}),
							a(h, e, r, i, n, f || c)
					}))
			},
			t.fn.off = function (e, n, i) {
				var r = this;
				return e && !d(e) ? (t.each(e,
					function (t, e) {
						r.off(t, n, e)
					}), r) : (d(n) || h(i) || !1 === i || (i = n, n = u), !1 === i && (i = w), r.each(function () {
						s(this, e, i, n)
					}))
			},
			t.fn.trigger = function (e, n) {
				return e = d(e) || t.isPlainObject(e) ? t.Event(e) : c(e),
					e._args = n,
					this.each(function () {
						"dispatchEvent" in this ? this.dispatchEvent(e) : t(this).triggerHandler(e, n)
					})
			},
			t.fn.triggerHandler = function (e, i) {
				var r, o;
				return this.each(function (a, s) {
					(r = l(d(e) ? t.Event(e) : e))._args = i,
					r.target = s,
					t.each(n(s, e.type || e),
						function (t, e) {
							return o = e.proxy(r),
								!r.isImmediatePropagationStopped() && void 0
						})
				}),
					o
			},
			"focusin focusout load resize scroll unload click dblclick mousedown mouseup mousemove mouseover mouseout mouseenter mouseleave change select keydown keypress keyup error".split(" ").forEach(function (e) {
				t.fn[e] = function (t) {
					return t ? this.bind(e, t) : this.trigger(e)
				}
			}),
			["focus", "blur"].forEach(function (e) {
				t.fn[e] = function (t) {
					return t ? this.bind(e, t) : this.each(function () {
						try {
							this[e]()
						} catch (t) { }
					}),
						this
				}
			}),
			t.Event = function (t, e) {
				d(t) || (e = t, t = e.type);
				var n = document.createEvent(g[t] || "Events"),
					i = !0;
				if (e) for (var r in e) "bubbles" == r ? i = !!e[r] : n[r] = e[r];
				return n.initEvent(t, i, !0),
					c(n)
			}
	}(Zepto),
	function (t) {
		function e(e, n, i) {
			var r = t.Event(n);
			return t(e).trigger(r, i),
				!r.isDefaultPrevented()
		}
		function n(t, n, i, r) {
			return t.global ? e(n || v, i, r) : void 0
		}
		function i(e) {
			e.global && 0 == t.active++ && n(e, null, "ajaxStart")
		}
		function r(e) {
			e.global && !--t.active && n(e, null, "ajaxStop")
		}
		function o(t, e) {
			var i = e.context;
			return !1 !== e.beforeSend.call(i, t, e) && !1 !== n(e, i, "ajaxBeforeSend", [t, e]) && void n(e, i, "ajaxSend", [t, e])
		}
		function a(t, e, i, r) {
			var o = i.context,
				a = "success";
			i.success.call(o, t, a, e),
				r && r.resolveWith(o, [t, a, e]),
				n(i, o, "ajaxSuccess", [e, i, t]),
				c(a, e, i)
		}
		function s(t, e, i, r, o) {
			var a = r.context;
			r.error.call(a, i, e, t),
				o && o.rejectWith(a, [i, e, t]),
				n(r, a, "ajaxError", [i, r, t || e]),
				c(e, i, r)
		}
		function c(t, e, i) {
			var o = i.context;
			i.complete.call(o, e, t),
				n(i, o, "ajaxComplete", [e, i]),
				r(i)
		}
		function l() { }
		function u(t) {
			return t && (t = t.split(";", 2)[0]),
				t && (t == T ? "html" : t == w ? "json" : b.test(t) ? "script" : x.test(t) && "xml") || "text"
		}
		function f(t, e) {
			return "" == e ? t : (t + "&" + e).replace(/[&?]{1,2}/, "?")
		}
		function p(e, n, i, r) {
			return t.isFunction(n) && (r = i, i = n, n = void 0),
				t.isFunction(i) || (r = i, i = void 0),
			{
				url: e,
				data: n,
				success: i,
				dataType: r
			}
		}
		function h(e, n, i, r) {
			var o, a = t.isArray(n),
				s = t.isPlainObject(n);
			t.each(n,
				function (n, c) {
					o = t.type(c),
						r && (n = i ? r : r + "[" + (s || "object" == o || "array" == o ? n : "") + "]"),
						!r && a ? e.add(c.name, c.value) : "array" == o || !i && "object" == o ? h(e, c, i, n) : e.add(n, c)
				})
		}
		var d, m, g = 0,
			v = window.document,
			y = /<script\b[^<]*(?:(?!<\/script>)<[^<]*)*<\/script>/gi,
			b = /^(?:text|application)\/javascript/i,
			x = /^(?:text|application)\/xml/i,
			w = "application/json",
			T = "text/html",
			C = /^\s*$/;
		t.active = 0,
			t.ajaxJSONP = function (e, n) {
				if (!("type" in e)) return t.ajax(e);
				var i, r, c = e.jsonpCallback,
					l = (t.isFunction(c) ? c() : c) || "jsonp" + ++g,
					u = v.createElement("script"),
					f = window[l],
					p = function (e) {
						t(u).triggerHandler("error", e || "abort")
					},
					h = {
						abort: p
					};
				return n && n.promise(h),
					t(u).on("load error",
						function (o, c) {
							clearTimeout(r),
								t(u).off().remove(),
								"error" != o.type && i ? a(i[0], h, e, n) : s(null, c || "error", h, e, n),
								window[l] = f,
								i && t.isFunction(f) && f(i[0]),
								f = i = void 0
						}),
					!1 === o(h, e) ? (p("abort"), h) : (window[l] = function () {
						i = arguments
					},
						u.src = e.url.replace(/\?(.+)=\?/, "?$1=" + l), v.head.appendChild(u), e.timeout > 0 && (r = setTimeout(function () {
							p("timeout")
						},
							e.timeout)), h)
			},
			t.ajaxSettings = {
				type: "GET",
				beforeSend: l,
				success: l,
				error: l,
				complete: l,
				context: null,
				global: !0,
				xhr: function () {
					return new window.XMLHttpRequest
				},
				accepts: {
					script: "text/javascript, application/javascript, application/x-javascript",
					json: w,
					xml: "application/xml, text/xml",
					html: T,
					text: "text/plain"
				},
				crossDomain: !1,
				timeout: 0,
				processData: !0,
				cache: !0
			},
			t.ajax = function (e) {
				var n = t.extend({},
					e || {}),
					r = t.Deferred && t.Deferred();
				for (d in t.ajaxSettings) void 0 === n[d] && (n[d] = t.ajaxSettings[d]);
				i(n),
					n.crossDomain || (n.crossDomain = /^([\w-]+:)?\/\/([^\/]+)/.test(n.url) && RegExp.$2 != window.location.host),
					n.url || (n.url = window.location.toString()),
					function (e) {
						e.processData && e.data && "string" != t.type(e.data) && (e.data = t.param(e.data, e.traditional)),
							!e.data || e.type && "GET" != e.type.toUpperCase() || (e.url = f(e.url, e.data), e.data = void 0)
					}(n);
				var c = n.dataType,
					p = /\?.+=\?/.test(n.url);
				if (p && (c = "jsonp"), !1 !== n.cache && (e && !0 === e.cache || "script" != c && "jsonp" != c) || (n.url = f(n.url, "_=" + Date.now())), "jsonp" == c) return p || (n.url = f(n.url, n.jsonp ? n.jsonp + "=?" : !1 === n.jsonp ? "" : "callback=?")),
					t.ajaxJSONP(n, r);
				var h, g = n.accepts[c],
					v = {},
					y = function (t, e) {
						v[t.toLowerCase()] = [t, e]
					},
					b = /^([\w-]+:)\/\//.test(n.url) ? RegExp.$1 : window.location.protocol,
					x = n.xhr(),
					w = x.setRequestHeader;
				if (r && r.promise(x), n.crossDomain || y("X-Requested-With", "XMLHttpRequest"), y("Accept", g || "*/*"), (g = n.mimeType || g) && (g.indexOf(",") > -1 && (g = g.split(",", 2)[0]), x.overrideMimeType && x.overrideMimeType(g)), (n.contentType || !1 !== n.contentType && n.data && "GET" != n.type.toUpperCase()) && y("Content-Type", n.contentType || "application/x-www-form-urlencoded"), n.headers) for (m in n.headers) y(m, n.headers[m]);
				if (x.setRequestHeader = y, x.onreadystatechange = function () {
					if (4 == x.readyState) {
						x.onreadystatechange = l,
							clearTimeout(h);
						var e, i = !1;
						if (x.status >= 200 && x.status < 300 || 304 == x.status || 0 == x.status && "file:" == b) {
							c = c || u(n.mimeType || x.getResponseHeader("content-type")),
								e = x.responseText;
							try {
								"script" == c ? (0, eval)(e) : "xml" == c ? e = x.responseXML : "json" == c && (e = C.test(e) ? null : t.parseJSON(e))
							} catch (t) {
								i = t
							}
							i ? s(i, "parsererror", x, n, r) : a(e, x, n, r)
						} else s(x.statusText || null, x.status ? "error" : "abort", x, n, r)
					}
				},
					!1 === o(x, n)) return x.abort(),
						s(null, "abort", x, n, r),
						x;
				if (n.xhrFields) for (m in n.xhrFields) x[m] = n.xhrFields[m];
				var T = !("async" in n) || n.async;
				x.open(n.type, n.url, T, n.username, n.password);
				for (m in v) w.apply(x, v[m]);
				return n.timeout > 0 && (h = setTimeout(function () {
					x.onreadystatechange = l,
						x.abort(),
						s(null, "timeout", x, n, r)
				},
					n.timeout)),
					x.send(n.data ? n.data : null),
					x
			},
			t.get = function () {
				return t.ajax(p.apply(null, arguments))
			},
			t.post = function () {
				var e = p.apply(null, arguments);
				return e.type = "POST",
					t.ajax(e)
			},
			t.getJSON = function () {
				var e = p.apply(null, arguments);
				return e.dataType = "json",
					t.ajax(e)
			},
			t.fn.load = function (e, n, i) {
				if (!this.length) return this;
				var r, o = this,
					a = e.split(/\s/),
					s = p(e, n, i),
					c = s.success;
				return a.length > 1 && (s.url = a[0], r = a[1]),
					s.success = function (e) {
						o.html(r ? t("<div>").html(e.replace(y, "")).find(r) : e),
							c && c.apply(o, arguments)
					},
					t.ajax(s),
					this
			};
		var E = encodeURIComponent;
		t.param = function (t, e) {
			var n = [];
			return n.add = function (t, e) {
				this.push(E(t) + "=" + E(e))
			},
				h(n, t, e),
				n.join("&").replace(/%20/g, "+")
		}
	}(Zepto),
	function (t) {
		t.fn.serializeArray = function () {
			var e, n = [];
			return t([].slice.call(this.get(0).elements)).each(function () {
				var i = (e = t(this)).attr("type");
				"fieldset" != this.nodeName.toLowerCase() && !this.disabled && "submit" != i && "reset" != i && "button" != i && ("radio" != i && "checkbox" != i || this.checked) && n.push({
					name: e.attr("name"),
					value: e.val()
				})
			}),
				n
		},
			t.fn.serialize = function () {
				var t = [];
				return this.serializeArray().forEach(function (e) {
					t.push(encodeURIComponent(e.name) + "=" + encodeURIComponent(e.value))
				}),
					t.join("&")
			},
			t.fn.submit = function (e) {
				if (e) this.bind("submit", e);
				else if (this.length) {
					var n = t.Event("submit");
					this.eq(0).trigger(n),
						n.isDefaultPrevented() || this.get(0).submit()
				}
				return this
			}
	}(Zepto),
	function (t) {
		"__proto__" in {} || t.extend(t.zepto, {
			Z: function (e, n) {
				return e = e || [],
					t.extend(e, t.fn),
					e.selector = n || "",
					e.__Z = !0,
					e
			},
			isZ: function (e) {
				return "array" === t.type(e) && "__Z" in e
			}
		});
		try {
			getComputedStyle(void 0)
		} catch (t) {
			var e = getComputedStyle;
			window.getComputedStyle = function (t) {
				try {
					return e(t)
				} catch (t) {
					return null
				}
			}
		}
	}(Zepto),
	function (t) {
		t.fn.More = function (e) {
			var n = t.extend({
				Box: "#classify-one",
				Type: "1",
				Current: "on",
				ConHt: "66",
				insert: ".more-con",
				Text1: "展开",
				Text2: "收起"
			},
				e);
			return this.each(function () {
				var e, i = t(n.Box),
					r = t(n.Box).find(".more-bd");
				e = r.height(),
					$more1 = '<div class="more-btn"><a href="javascript:void(0)">' + n.Text1 + "</a></div>",
					$more2 = '<div class="more-btn"><a href="javascript:void(0)">' + n.Text1 + '<i class="ft-icon">R</i></a></div>',
					e < n.ConHt && i.height("auto"),
					e > n.ConHt && 1 != n.Type && (t($more2).insertAfter(n.insert), i.height(n.ConHt + "px")),
					e > n.ConHt && 1 == n.Type && (t($more1).insertAfter(n.insert), i.height(n.ConHt + "px")),
					t(document).on("click", ".more-btn a",
						function () {
							function e() {
								r.find(".more-bd").height();
								r.find(".more-con").height("auto").css("transition", "200ms"),
									r.find(".more-btn").remove()
							}
							var r = t(this).parent().parent(),
								o = t(this).parent().parent(".tab-item").find(".more-bd").height();
							r.is(".tab-item") && 1 == n.Type && (r.parent().parent().add(r.find(".more-con")).height("auto").css("transition", "200ms"), r.find(".more-btn").remove()),
								n.Type > 1 && e(),
								1 == n.Type && e(),
								1 != n.Type && n.Type > 2 && (t(this).toggleClass(n.Current), t(this).is("." + n.Current) ? t(this).text("" + n.Text2) && i.height(o + "px").css("transition", "200ms") : t(this).text("" + n.Text1) && i.height(n.ConHt + "px").css("transition", "200ms"))
						})
			})
		},
			t.fn.lazyBox = function (e) {
				var n = t.extend({
					ClassName: ".box img[data-original]",
					ImgAttr: "data-original"
				},
					e),
					i = null;
				t(window).on("scroll resize",
					function () {
						i && clearTimeout(i),
							i = setTimeout(function () {
								!
								function () {
									for (var e = 0,
										i = t(n.ClassName).length; e < i; e++) {
										var r = t(n.ClassName).eq(e),
											o = r.attr(n.ImgAttr);
										r.offset().top + r.height() >= t(window).scrollTop() && r.offset().top < t(window).scrollTop() + t(window).height() && r.attr("src") !== o && r.attr(n.ImgAttr) && r.attr("src", o)
									}
								}()
							},
								0)
					}).trigger("scroll")
			},
			Zepto(function (t) {
				function e(e) {
					e.find("img").each(function () {
						var e = t(this).attr("original");
						e && t(this).attr("src", e)
					})
				}
				function n(t, n) {
					var i = t.find("article").eq(n);
					t.find("article").eq(n).addClass("tab-item").siblings().removeClass("tab-item"),
						e(i)
				}
				function i(t, e) {
					var n = t.find("article").eq(e),
						i = parseInt(n.children("header").height() + n.children("ul").height() + n.children("div").height() + n.children("section").height());
					n.closest(".tempWrap").height(i),
						0 === n.closest(".tempWrap").height() && n.closest(".tempWrap").height("auto"),
						e > 0 && (n.closest(".tempWrap")[0].style.transition = "200ms")
				}
				TouchSlide({
					slideCell: "#tab-one",
					startFun: function (e, i) {
						n(t("#tab-one"), e)
					},
					endFun: function (e) {
						i(t("#tab-one"), e)
					}
				}),
					TouchSlide({
						slideCell: "#tab-two",
						startFun: function (e, i) {
							n(t("#tab-two"), e)
						},
						endFun: function (e) {
							i(t("#tab-two"), e)
						}
					}),
					TouchSlide({
						slideCell: "#tab-three",
						startFun: function (e, i) {
							n(t("#tab-three"), e)
						},
						endFun: function (e) {
							i(t("#tab-three"), e)
						}
					}),
					TouchSlide({
						slideCell: "#tab-four",
						startFun: function (e, i) {
							n(t("#tab-four"), e)
						},
						endFun: function (e) {
							i(t("#tab-four"), e)
						}
					}),
					TouchSlide({
						slideCell: "#tab-five",
						startFun: function (e, i) {
							n(t("#tab-five"), e)
						},
						endFun: function (e) {
							i(t("#tab-five"), e)
						}
					}),
					TouchSlide({
						slideCell: "#tab-six",
						startFun: function (e, i) {
							n(t("#tab-six"), e)
						},
						endFun: function (e) {
							i(t("#tab-six"), e)
						}
					}),
					t(".tab-list .hd li").click(function () {
						var n = t(this).index(),
							i = t(this).parents("header").parent().find("article").eq(n);
						i.addClass("tab-item").siblings().removeClass("tab-item"),
							e(i)
					}),
					t(".box img[data-original]").lazyBox();
				var r = t(".top-nav");
				t("#classify").click(function () {
					return r.css("visibility", "visible").show(),
						t("body,html").scrollTop(0),
						!1
				}),
					t(".top-nav .bg").click(function () {
						return r.hide(),
							!1
					});
				var o = t("#go-top");
				o.length > 0 && (t(window).scroll(function () {
					t(this).scrollTop() >= 300 ? o.show() : o.hide()
				}), o.find("a").click(function () {
					t("body,html").scrollTop(0)
				})),
					window.onload = function () {
						function e() {
							t(".classify-box .more-con").css({
								height: "auto",
								"max-height": "none"
							}),
								t(".classify-box .more-btn").css("display", "none")
						}
						var n = t(".classify-box .on");
						n[0] && n.position().top > 0 && n.position().left >= t(".classify-box li").eq(3).position().left && e(),
							n[0] && n.position().top >= 100 && e()
					},
					t("#btns a").click(function () {
						t(".down-show").removeClass("ds-n")
					}),
					t(".body-bg,.alert-title i").click(function () {
						t(".down-show").addClass("ds-n")
					}),
					t(".details-bd .title").each(function () {
						"小编推荐" == t(this).text() && t(this).hide()
					});
				t("body").append('<div id="big-img"></div>'),
					function (t, e) {
						var e = e ||
							function () { },
							n = document.getElementsByTagName("head")[0];
						script = document.createElement("script"),
							script.src = t,
							n.appendChild(script),
							script.onload = e
					}("//m.8xia.com/statics/v2/js/swiper.js",
						function () {
							var e = function (e, n) {
								t("#big-img").append('<div class="big-img"><div class="details-swiper big-swiper"><div class="swiper-wrapper"></div><div class="swiper-pagination"></div></div><div class="close">X</div><style>.swiper-wrapper {position: relative;width: 100%;height: 100%;z-index: 1;display: -webkit-box;display: -moz-box;display: -ms-flexbox;display: -webkit-flex;display: flex;-webkit-transition-property: -webkit-transform;-moz-transition-property: -moz-transform;-o-transition-property: -o-transform;-ms-transition-property: -ms-transform;transition-property: transform;-webkit-box-sizing: content-box;-moz-box-sizing: content-box;box-sizing: content-box}.swiper-slide {-webkit-flex-shrink: 0;-ms-flex: 0 0 auto;flex-shrink: 0;width: 100%;height: 100%;position: relative}.big-img{position:fixed;z-index:-1;opacity:0;background:#0d0d0d;width:100%;height:100%;top:0;left:0}.big-img .details-swiper{position:relative;width:100%;height:100%}.big-img .details-swiper .swiper-wrapper{width:100%;height:100%}.big-img .swiper-slide{width:100%;height:100%;display:table}.big-img .swiper-slide .cell{width:100%;height:100%;display:table-cell;vertical-align:middle;text-align:center}.big-img .swiper-slide img{max-width:100%;margin:0 auto}.big-img .swiper-pagination2{position:absolute;top:.2rem;text-align:center;width:100%}.big-img .swiper-pagination2 span{margin:.05rem}.big-img .close{color:#c2c3c4;font-size:1pc;position:absolute;right:10px;top:8px;display:block}.big-img .swiper-pagination{color:#c2c3c4;font-size:14px;width:auto;position:absolute;left:10px;top:10px}</style></div>');
								for (var i = e.find("img"), r = 0, o = i.length; r < o; r++) t(".big-img .swiper-wrapper").append('<div class="swiper-slide"><div class="cell swiper-zoom-container"><img src="' + i.eq(r).attr("src") + '"></div></div>');
								return new Swiper(".details-swiper", {
									pagination: ".swiper-pagination",
									paginationType: "fraction",
									observer: !0,
									observeParents: !0,
									zoom: !0
								}).slideTo(n, 0, !1),
									t(".big-img").css({
										"z-index": 999999999,
										opacity: "1"
									}),
									!1
							};
							t("#details-pic img").on("click",
								function () {
									var n = t(this).parents("#details-pic").find("img").index(this);
									e(t("#details-pic"), n)
								}),
								t(".details-bd img").on("click",
									function () {
										var n = t(this).parents(".details-bd").find("img").index(this);
										e(t(".details-bd"), n)
									}),
								t("#big-img").on("click", ".big-img",
									function () {
										t(this).remove()
									})
						});
			})
	}(Zepto);
var TouchSlide = function (t) {
	var e = {
		slideCell: (t = t || {}).slideCell || "#touchSlide",
		titCell: t.titCell || ".hd li",
		mainCell: t.mainCell || ".bd",
		effect: t.effect || "left",
		autoPlay: t.autoPlay || !1,
		delayTime: t.delayTime || 200,
		interTime: t.interTime || 2500,
		defaultIndex: t.defaultIndex || 0,
		titOnClassName: t.titOnClassName || "on",
		autoPage: t.autoPage || !1,
		prevCell: t.prevCell || ".prev",
		nextCell: t.nextCell || ".next",
		pageStateCell: t.pageStateCell || ".pageState",
		pnLoop: "undefined " == t.pnLoop || t.pnLoop,
		startFun: t.startFun || null,
		endFun: t.endFun || null,
		switchLoad: t.switchLoad || null
	},
		n = document.getElementById(e.slideCell.replace("#", ""));
	if (!n) return !1;
	var i = function (t, e) {
		t = t.split(" ");
		var n = [],
			i = [e = e || document];
		for (var r in t) 0 != t[r].length && n.push(t[r]);
		for (var r in n) {
			if (0 == i.length) return !1;
			var o = [];
			for (var a in i) if ("#" == n[r][0]) o.push(document.getElementById(n[r].replace("#", "")));
			else if ("." == n[r][0]) for (var s = i[a].getElementsByTagName("*"), c = 0; c < s.length; c++) {
				var l = s[c].className;
				l && -1 != l.search(new RegExp("\\b" + n[r].replace(".", "") + "\\b")) && o.push(s[c])
			} else for (var s = i[a].getElementsByTagName(n[r]), c = 0; c < s.length; c++) o.push(s[c]);
			i = o
		}
		return 0 != i.length && i[0] != e && i
	},
		r = function (t, e) {
			!t || !e || t.className && -1 != t.className.search(new RegExp("\\b" + e + "\\b")) || (t.className += (t.className ? " " : "") + e)
		},
		o = function (t, e) {
			!t || !e || t.className && -1 == t.className.search(new RegExp("\\b" + e + "\\b")) || (t.className = t.className.replace(new RegExp("\\s*\\b" + e + "\\b", "g"), ""))
		},
		a = e.effect,
		s = i(e.prevCell, n)[0],
		c = i(e.nextCell, n)[0],
		l = i(e.pageStateCell)[0],
		u = i(e.mainCell, n)[0];
	if (!u) return !1;
	var f, p, h = u.children.length,
		d = i(e.titCell, n),
		m = d ? d.length : h,
		g = e.switchLoad,
		v = parseInt(e.defaultIndex),
		y = parseInt(e.delayTime),
		b = parseInt(e.interTime),
		x = "false" != e.autoPlay && 0 != e.autoPlay,
		w = "false" != e.autoPage && 0 != e.autoPage,
		T = "false" != e.pnLoop && 0 != e.pnLoop,
		C = v,
		E = null,
		N = null,
		S = null,
		j = 0,
		L = 0,
		k = 0,
		P = 0,
		O = /hp-tablet/gi.test(navigator.appVersion),
		z = "ontouchstart" in window && !O,
		A = z ? "touchstart" : "mousedown",
		F = z ? "touchmove" : "",
		M = z ? "touchend" : "mouseup",
		D = u.parentNode.clientWidth,
		$ = h;
	if (0 == m && (m = h), w) {
		m = h,
			(d = d[0]).innerHTML = "";
		var I = "";
		if (1 == e.autoPage || "true" == e.autoPage) for (_ = 0; m > _; _++) I += "<li>" + (_ + 1) + "</li>";
		else for (_ = 0; m > _; _++) I += e.autoPage.replace("$", _ + 1);
		d.innerHTML = I,
			d = d.children
	}
	"leftLoop" == a && ($ += 2, u.appendChild(u.children[0].cloneNode(!0)), u.insertBefore(u.children[h - 1].cloneNode(!0), u.children[0])),
		f = function (t, e) {
			var n = document.createElement("div");
			n.innerHTML = e,
				n = n.children[0];
			var i = t.cloneNode(!0);
			return n.appendChild(i),
				t.parentNode.replaceChild(n, t),
				u = i,
				n
		}(u, '<div class="tempWrap" style="overflow:hidden; position:relative;"></div>'),
		u.style.cssText = "width:" + $ * D + "px;position:relative;overflow:hidden;padding:0;margin:0;";
	for (_ = 0; $ > _; _++) u.children[_].style.cssText = "display:table-cell;vertical-align:top;width:" + D + "px";
	var Z = function (t) {
		var e = ("leftLoop" == a ? v + 1 : v) + t,
			n = function (t) {
				for (var e = u.children[t].getElementsByTagName("img"), n = 0; n < e.length; n++) e[n].getAttribute(g) && (e[n].setAttribute("src", e[n].getAttribute(g)), e[n].removeAttribute(g))
			};
		if (n(e), "leftLoop" == a) switch (e) {
			case 0:
				n(h);
				break;
			case 1:
				n(h + 1);
				break;
			case h:
				n(0);
				break;
			case h + 1: n(1)
		}
	};
	window.addEventListener("resize",
		function () {
			D = f.clientWidth,
				u.style.width = $ * D + "px";
			for (var t = 0; $ > t; t++) u.children[t].style.width = D + "px";
			R(- ("leftLoop" == a ? v + 1 : v) * D, 0)
		},
		!1);
	var R = function (t, e, n) {
		(n = n ? n.style : u.style).webkitTransitionDuration = n.MozTransitionDuration = n.msTransitionDuration = n.OTransitionDuration = n.transitionDuration = e + "ms",
		n.webkitTransform = "translate(" + t + "px,0)translateZ(0)",
		n.msTransform = n.MozTransform = n.OTransform = "translateX(" + t + "px)"
	},
		H = function (t) {
			switch (a) {
				case "left":
					v >= m ? v = t ? v - 1 : 0 : 0 > v && (v = t ? 0 : m - 1),
						null != g && Z(0),
						R(- v * D, y),
						C = v;
					break;
				case "leftLoop":
					null != g && Z(0),
						R(- (v + 1) * D, y),
						-1 == v ? (N = setTimeout(function () {
							R(- m * D, 0)
						},
							y), v = m - 1) : v == m && (N = setTimeout(function () {
								R(- D, 0)
							},
								y), v = 0),
						C = v
			}
			"function" == typeof e.startFun && e.startFun(v, m),
				S = setTimeout(function () {
					"function" == typeof e.endFun && e.endFun(v, m)
				},
					y);
			for (var n = 0; m > n; n++) o(d[n], e.titOnClassName),
				n == v && r(d[n], e.titOnClassName);
			0 == T && (o(c, "nextStop"), o(s, "prevStop"), 0 == v ? r(s, "prevStop") : v == m - 1 && r(c, "nextStop")),
				l && (l.innerHTML = "<span>" + (v + 1) + "</span>/" + m)
		};
	if (H(), x && (E = setInterval(function () {
		v++,
			H()
	},
		b)), d) for (var _ = 0; m > _; _++) !
			function () {
				var t = _;
				d[t].addEventListener("click",
					function () {
						clearTimeout(N),
							clearTimeout(S),
							v = t,
							H()
					})
			}();
	c && c.addEventListener("click",
		function () {
			(1 == T || v != m - 1) && (clearTimeout(N), clearTimeout(S), v++, H())
		}),
		s && s.addEventListener("click",
			function () {
				(1 == T || 0 != v) && (clearTimeout(N), clearTimeout(S), v--, H())
			});
	var B = function (t) {
		if (!z || !(t.touches.length > 1 || t.scale && 1 !== t.scale)) {
			var e = z ? t.touches[0] : t;
			if (k = e.pageX - j, P = e.pageY - L, void 0 === p && (p = !!(p || Math.abs(k) < Math.abs(P))), !p) {
				switch (t.preventDefault(), x && clearInterval(E), a) {
					case "left":
						(0 == v && k > 0 || v >= m - 1 && 0 > k) && (k *= .4),
							R(- v * D + k, 0);
						break;
					case "leftLoop":
						R(- (v + 1) * D + k, 0)
				}
				null != g && Math.abs(k) > D / 3 && Z(k > -0 ? -1 : 1)
			}
		}
	},
		q = function (t) {
			0 != k && (t.preventDefault(), p || (Math.abs(k) > D / 10 && (k > 0 ? v-- : v++), H(!0), x && (E = setInterval(function () {
				v++,
					H()
			},
				b))), u.removeEventListener(F, B, !1), u.removeEventListener(M, q, !1))
		};
	u.addEventListener(A,
		function (t) {
			clearTimeout(N),
				clearTimeout(S),
				p = void 0,
				k = 0;
			var e = z ? t.touches[0] : t;
			j = e.pageX,
				L = e.pageY,
				u.addEventListener(F, B, !1),
				u.addEventListener(M, q, !1)
		},
		!1)
};