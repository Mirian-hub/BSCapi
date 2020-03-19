

$(function (e) {
    var parameter = $(this).find("input[type = 'hidden']").val();
    var targetTableId;
    var targetTableGroupId;
    var tmp = e.selector;
    //$("#dataTable").dataTable().fnDestroy();
    //$("#dataTableGroup").dataTable().fnDestroy();
   

    if (targetId === '1') {
        $("#dataTable").DataTable({
            "ajax": {
                "url": "/Manu/GetListView",
                "type": "GET",
                "datatype": "json",
                data: { operationId: parameter }
            },
            "columns": [
                { "data": "Id" },
                { "data": "Name" },
                { "data": "Format" },
                { "data": "Key" },
                { "data": "Code" },
                { "data": "GroupId" },

            ],


        });

        $("#dataTableGroup").DataTable({
            "ajax": {
                "url": "/Manu/GetGroupList",
                "type": "GET",
                "datatype": "json",
                "data": "{operationId :parameter }",
            },
            "columns": [
                { "data": "Key" },
                { "data": "Name" },
            ],
        });

      



        $("#dataTable").css("display", "table")
        $("#dataTableGroup").css("display", "table")

    }
    else {

        $(".list2").last().css("display", "table ")
        $(".group2").last().css("display", "table ")

        $(".list2").last().DataTable({
            "ajax": {
                "url": "/Manu/GetListView2",
                "type": "GET",
                "datatype": "json",
                data: { operationId: parameter }
            },
            "columns": [
                { "data": "Id" },
                { "data": "Name" },
                { "data": "Format" },
                { "data": "Key" },
                { "data": "Code" },
                { "data": "GroupId" }

            ],


        });


        $(".group2").last().DataTable({
            "ajax": {
                "url": "/Manu/GetGroupList",
                "type": "GET",
                "datatype": "json",
                "data": "{operationId :parameter }",
            },
            "columns": [
                { "data": "Key" },
                { "data": "Name" },
            ],
        });
    }
})