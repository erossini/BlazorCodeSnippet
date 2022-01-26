function highlightSnippet() {
	document.querySelectorAll('pre code').forEach((el) => {
		hljs.highlightElement(el);
	});
}

function loadJs(sourceUrl) {
	if (sourceUrl.Length == 0) {
		console.error("Invalid source URL");
		return;
	}

	var tag = document.createElement('script');
	tag.src = sourceUrl;
	tag.type = "text/javascript";

	tag.onload = function () {
		highlightSnippet();
		console.log("Script loaded successfully");
	}

	tag.onerror = function () {
		console.error("Failed to load script");
	}

	document.body.appendChild(tag);
}

function loadCSS(sourceUrl) {
	if (sourceUrl.Length == 0) {
		console.error("Invalid source URL");
		return;
	}

	var link = document.createElement('link');
	link.rel = "stylesheet";
	link.type = "text/css";
	link.href = sourceUrl;

	link.onload = function () {
		console.log("CSS loaded successfully");
	}

	link.onerror = function () {
		console.error("CSS to load script");
	}

	document.head.appendChild(link);
}