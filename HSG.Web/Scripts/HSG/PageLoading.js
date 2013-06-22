function onBeginRequest() {
    var divBlurImage = document.getElementById('divBlur');
    if (divBlurImage) {
        divBlurImage.className = 'blur_image';
        document.getElementById('divMasterLoading').style.display = "inline";
        onPageScroll();
    }
}

function onEndRequest() {
    var divBlurImage = document.getElementById('divBlur');
    if (divBlurImage) {
        document.getElementById('divMasterLoading').style.display = "none";
        divBlurImage.className = '';
        divBlurImage.style.width = 0;
        divBlurImage.style.height = 0;
    }
}

function onPageScroll() {
    var divBlurImage = document.getElementById('divBlur');
    var divLoading = document.getElementById('divMasterLoading');
    if (document.getElementById('divBlur')) $("#divBlur").css("top", Math.max(0, 100 + $(this).scrollTop()));
    if (document.getElementById('divMasterLoading')) $("#divMasterLoading").css("top", Math.max(0, $(this).scrollTop()));
}

/**
* Method to get the browser height and width.
*/
function getBrowserSize() {
    var myWidth = 0, myHeight = 0;
    if (typeof (window.innerWidth) == 'number') {
        //Non-IE
        myWidth = window.innerWidth;
        myHeight = window.innerHeight;
    } else if (document.documentElement && (document.documentElement.clientWidth || document.documentElement.clientHeight)) {
        //IE 6+ in 'standards compliant mode'
        myWidth = document.documentElement.clientWidth;
        myHeight = document.documentElement.clientHeight;
    } else if (document.body && (document.body.clientWidth || document.body.clientHeight)) {
        //IE 4 compatible
        myWidth = document.body.clientWidth;
        myHeight = document.body.clientHeight;
    }
    return [myWidth, myHeight];
}

/**
* Method to get the browser scroll x and y co-ordinates.
*/
function getScrollXY() {
    var scrOfX = 0, scrOfY = 0;
    if (typeof (window.pageYOffset) == 'number') {
        //Netscape compliant
        scrOfY = window.pageYOffset;
        scrOfX = window.pageXOffset;
    } else if (document.body && (document.body.scrollLeft || document.body.scrollTop)) {
        //DOM compliant
        scrOfY = document.body.scrollTop;
        scrOfX = document.body.scrollLeft;
    } else if (document.documentElement && (document.documentElement.scrollLeft || document.documentElement.scrollTop)) {
        //IE6 standards compliant mode
        scrOfY = document.documentElement.scrollTop;
        scrOfX = document.documentElement.scrollLeft;
    }
    return [scrOfX, scrOfY];
}


function onLinkButtonEnterKey(e, btnId) {
    var btn = document.getElementById(btnId);
    if (typeof (btn) == 'object') {
        if (navigator.appName.indexOf("Netscape") > -1) {
            if (btn && typeof (btn.click) == 'undefined') {
                btn.click = addClickFunction(btn);
            }
        }
        if (navigator.appName.indexOf("Microsoft Internet Explorer") > -1) {
            btn.click();
            return false;
        }
    }
}

function addClickFunction(btn) {
    var result = true;
    if (btn.onclick) result = btn.onclick();
    if (typeof (result) == 'undefined' || result) {
        eval(btn.href);
    }
}