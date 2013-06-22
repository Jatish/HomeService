/*
Function to perform paging: Basically creates pages and returns as string, display frompage, to page and total pages
*/
//Paging related global variables
var currPage = 1;
var fromPage = '';
var toPage = '';
var totalItemCount = '';

function BuildPager(totalItemCount, currentPage, divPager) {
    if (totalItemCount > jsonAppData.PageSize) {
        var sb = '';
        if (psize == 1) psize = jsonAppData.PageSize;
        var maxPage = Math.ceil((parseInt(totalItemCount) / parseInt(psize))); // getting max no.of pages for all records
        sb += '<div class="records-paging">';
        sb += '<ul class="paging-1 fl-rt">';

        //Region Left arrow: Previous
        if (currentPage > 1) {
            sb = sb + '<li class="first"><a href="javascript:void(0);" onclick="FilterData(' + (currentPage - 1) + ');"><em></em></a></li>';
        }
        else {
            sb = sb + ("<li class=\"first\"><a><em></em></a></li>");
        }

        //Get Start Index and End Index here to create pages
        var iNoOfSlices = jsonAppData.NoOfSlices;
        if (currentPage <= iNoOfSlices - 1 && parseInt(maxPage) > iNoOfSlices) { // For first time loading 
            startInd = 1;
            endInd = iNoOfSlices;
        } else if (parseInt(maxPage) <= iNoOfSlices) {
            startInd = 1;
            endInd = maxPage;
        } else if (parseInt(currentPage) != parseInt(maxPage) && (currentPage != (parseInt(maxPage) - 1)) && parseInt(maxPage) > iNoOfSlices) {
            endInd = parseInt(currentPage) + 2;
            startInd = (parseInt(endInd) - parseInt(iNoOfSlices)) + 1;
        } else if (parseInt(currentPage) == parseInt(maxPage) && parseInt(maxPage) > iNoOfSlices) {// if curr page is last page
            startInd = parseInt(currentPage) - (parseInt(iNoOfSlices) - 1);
            endInd = maxPage;
        } else if (parseInt(currentPage) == (parseInt(maxPage) - 1) && parseInt(maxPage) > iNoOfSlices) {// if curr page is second last page
            startInd = parseInt(currentPage) - (parseInt(iNoOfSlices) - 2);
            endInd = parseInt(currentPage) + 1;
        }

        //Create pages here based on Start Index and End Index
        for (var i = startInd; i <= endInd; i++) {
            if (i == currentPage) {
                sb = sb + "<li class=\"on\"><a>" + i + "</a></li>";
            }
            else {
                sb = sb + '<li><a href="javascript:void(0);" onclick="FilterData(' + (i) + ');">' + i + '</a></li>';
            }
        }
        //Set From page and To page to display
        fromPage = (parseInt(currentPage) * parseInt(psize) - parseInt(psize) + 1);
        if (psize < maxPage && totalItemCount > ((parseInt(currentPage) * parseInt(psize)))) {
            toPage = (parseInt(currentPage) * parseInt(psize));
        } else if (totalItemCount > ((parseInt(currentPage) * parseInt(psize)))) {
            toPage = (parseInt(currentPage) * parseInt(psize));
        } else {
            toPage = totalItemCount;
        }

        //Region Right Arrow: Next
        if (currentPage < maxPage) {
            sb = sb + '<li class="last"><a href="javascript:void(0);" onclick="FilterData(' + (currentPage + 1) + ');"><em></em></a></li>';
        }
        else {
            sb = sb + ("<li class=\"last\"><a><em></em></a></li>");
        }
        sb += '</ul>';

        //Bind  frmtpag div with accurate fromPage and toPage
        var message = '<div  class="records">';
        message += 'Displaying ' + fromPage + '-' + toPage + ' of ' + totalItemCount + ' Records <b>|</b> Records Per Page: ';

        //Bind _ddlPage 
        message += '<select id="' + divPager + '_ddlPage" onchange="FilterData(1);" >';
        var noOfPages = Math.ceil(((parseInt(totalItemCount) / 5) - 1));
        noOfPages = ((noOfPages == 0) ? 1 : noOfPages);
        var tempNoOfPages = 0;
        for (var i = 1; i <= noOfPages; i++) {
            var iPSOpt = parseInt(jsonAppData.PageSize) + tempNoOfPages;
            if (iPSOpt > totalItemCount) iPSOpt = totalItemCount;
            jsonAppData.PageSize > totalItemCount ? iPSOpt = totalItemCount : iPSOpt;
            message += '<option value="' + iPSOpt + '" ' + (iPSOpt == psize ? 'selected="selected"' : '') + '>' + iPSOpt + '</option>';
            tempNoOfPages = tempNoOfPages + 5;
            if (iPSOpt > 50) break;
        }
        if (totalItemCount != iPSOpt) message += '<option value="' + totalItemCount + '" ' + (totalItemCount == psize ? 'selected="selected"' : '') + '>' + totalItemCount + '</option>';
        message += '</select>';
        message += '</div>';

        sb += message;
        sb += '</div>';

        $('#' + divPager).empty().append(sb);
        $('#' + divPager).show();

    } else {
        $('#' + divPager).hide();
    }
}
