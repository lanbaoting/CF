

function $obj(id) {
	return document.getElementById(id)
}

function loadDefault(js) {
	for (x in js) {
		document.write("<script language=javascript src='" + current_domain + "/template/default/js/" + js[x] + ".js'></script>");
	}
}