$(function (e) {
    //$("#ajaxCallTest").on("click", function () {
        $('#dataTable').DataTable({
            "ajax": {
                "url": "/Manu/GetListView",
                "type": "GET",
                "datatype": "json"
            },
            "columns": [
                { "data": "Id" },
                { "data": "Name" },
                { "data": "Format" },
                { "data": "Key" },
                { "data": "Code" }
            ]
    });
    $('#dataTableGroup').DataTable({
            "ajax": {
                "url": "/Manu/GetGroupList",
                "type": "GET",
                "datatype": "json"
            },
            "columns": [
                { "data": "Key" },
                { "data": "Name" },
            ]
        });
    //});     
    var atrgetEl = $(this);
   

    var targetDoc = document.getElementsByClassName("btn btn-primary target-");
    var secondLecBtns = document.getElementsByClassName("second-level-btn target-");
    var thirdLecBtns = document.getElementsByClassName("second-level-btn target-third");

    //targetDoc.append(secondLecBtns);
    //targetDoc.append(thirdLecBtns);

    for (let item of targetDoc) {
        item.addEventListener("click", function () {
            var id = $(this).find("input[type='hidden']").val();
            $.ajax({
                url: "/Manu/Tab?name" + id,
                method: "post",
                async: false,
                data: { id: id },
                success: function (text) {
                    response = text;
                }
            })
        })
    }

    for (let item of secondLecBtns) {
        item.addEventListener("click", function () {
            var id = $(this).find("input[type='hidden']").val();
            debugger;
            $.ajax({
                url: "/Manu/Tab?name" + id,
                method: "post",
                async: false,
                data: { id: id },
                success: function (text) {
                    response = text;
                }
            })
        })
    }

    for (let item of thirdLecBtns) {
        item.addEventListener("click", function () {
            var id = $(this).find("input[type='hidden']").val();
            $.ajax({
                url: "/Manu/Tab?name" + id,
                method: "post",
                async: false,
                data: { id: id },
                success: function (text) {
                    response = text;
                }
            })
        })
    }
      



    var tabTitle = $("#tab_title"),
        tabContent = $("#tab_content"),
        tabTemplate = "<li><a href='#{href}'>#{label}</a> <span class='ui-icon ui-icon-close' role='presentation'>Remove Tab</span></li>",
        tabCounter = 2;
    var tabs = $("#tabs").tabs();

//// Modal dialog init: custom buttons and a "close" callback resetting the form inside
            //var dialog = $("#dialog").dialog({
            //    autoOpen: false,
            //    modal: true,
            //    buttons: {
            //        Add: function () {
            //            addTab();
            //            $(this).dialog("close");
            //        },
            //        Cancel: function () {
            //            $(this).dialog("close");
            //        }
            //    },
            //    close: function () {
            //        form[0].reset();
            //    }
            //});

            // AddTab form: calls addTab function on submit and closes the dialog
            //var form = dialog.find("form").on("submit", function (event) {
            //    addTab();
            //    dialog.dialog("close");
            //    event.preventDefault();
            //});

            // $("#dLabel").on("click()", addTab());
            



    //function clickFunc(ids) {
    //    this.on("click", function () {
    //        $.ajax({
    //            url: "/Manu/Tab?name" + id,
    //            method: "post",
    //            async: false,
    //            data: { id: id },
    //            success: function (text) {
    //                response = text;
    //            }
    //        })
    //    });

    //    this.on("click", function addTab() {
    //        var label = tabTitle.val() || "Tab " + tabCounter + $('#dLabel').text(),
    //            ids = "tabs-" + tabCounter,
    //            li = $(tabTemplate.replace(/#\{href\}/g, "#" + ids).replace(/#\{label\}/g, label)),
    //            tabContentHtml = tabContent.val() || "Tab " + tabCounter + " content.";

    //        tabs.find(".ui-tabs-nav").append(li);
    //        tabs.append("<div id='" + ids + "'>" + response + "  </div>");
    //        tabs.tabs("refresh");
    //        tabCounter++;
    //    });

    //    debugger;

    //}


    for (let item of targetDoc) {
        item.addEventListener("click", function addTab() {
           var label =  item.text,
               id = "tabs-" + tabCounter,
               li = $(tabTemplate.replace(/#\{href\}/g, "#" + id).replace(/#\{label\}/g, label)),
               tabContentHtml = tabContent.val() || "Tab " + tabCounter + " content.";

           tabs.find(".ui-tabs-nav").append(li);
           tabs.append("<div id='" + id + "'>" + response + "  </div>");
           tabs.tabs("refresh");
           tabCounter++;
       });
    }
    for (let item of secondLecBtns) {
        item.addEventListener("click", function addTab() {
           var label =  item.text,
               id = "tabs-" + tabCounter,
               li = $(tabTemplate.replace(/#\{href\}/g, "#" + id).replace(/#\{label\}/g, label)),
               tabContentHtml = tabContent.val() || "Tab " + tabCounter + " content.";

           tabs.find(".ui-tabs-nav").append(li);
           tabs.append("<div id='" + id + "'>" + response + "  </div>");    
           tabs.tabs("refresh");
           tabCounter++;
       });
    }   
    for (let item of thirdLecBtns) {
        item.addEventListener("click", function addTab() {
           var label =  item.text,
               id = "tabs-" + tabCounter,
               li = $(tabTemplate.replace(/#\{href\}/g, "#" + id).replace(/#\{label\}/g, label)),
               tabContentHtml = tabContent.val() || "Tab " + tabCounter + " content.";

           tabs.find(".ui-tabs-nav").append(li);
           tabs.append("<div id='" + id + "'>" + response + "  </div>");
           tabs.tabs("refresh");
           tabCounter++;
       });
    }


    
    //$('.btn btn-primary target-')[0].on("click", function addTab() {
    //    var label = tabTitle.val() || "Tab " + tabCounter + $('#dLabel').text(),
    //        id = "tabs-" + tabCounter,
    //        li = $(tabTemplate.replace(/#\{href\}/g, "#" + id).replace(/#\{label\}/g, label)),
    //        tabContentHtml = tabContent.val() || "Tab " + tabCounter + " content.";
        
    //    tabs.find(".ui-tabs-nav").append(li);
    //    tabs.append("<div id='" + id + "'>" + response + "  </div>");
    //    tabs.tabs("refresh");
    //    tabCounter++;
    //});
        // Actual addTab function: adds new tab using the input from the form above
    function addTab() {
            var label = tabTitle.val() || "Tab " + tabCounter,
                id = "tabs-" + tabCounter,
                li = $(tabTemplate.replace(/#\{href\}/g, "#" + id).replace(/#\{label\}/g, label)),
                tabContentHtml = tabContent.val() || "Tab " + tabCounter + " content.";
            debugger;

            tabs.find(".ui-tabs-nav").append(li);
            tabs.append("<div id='" + id + "'><p>" + tabContentHtml + "</p></div>");
            tabs.tabs("refresh");
            tabCounter++;
        }

            // AddTab button: just opens the dialog
            $("#add_tab")
        .button()
                .on("click", function () {
        dialog.dialog("open");
    });

    // Close icon: removing the tab on click
     tabs.on("click", "span.ui-icon-close", function () {
                    var panelId = $(this).closest("li").remove().attr("aria-controls");
        $("#" + panelId).remove();
        tabs.tabs("refresh");
    });

                tabs.on("keyup", function (event) {
                    if (event.altKey && event.keyCode === $.ui.keyCode.BACKSPACE) {
                        var panelId = tabs.find(".ui-tabs-active").remove().attr("aria-controls");
        $("#" + panelId).remove();
        tabs.tabs("refresh");
    }
});
});