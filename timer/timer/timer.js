var begintime;
var endtime;

function begin() {
    begintime = new Date();

}

function end() {
    endtime = new Date();
    var sum = (endtime - begintime) / 1000;
    ///alert(sum);

    $.ajax({
        url: "timer.aspx/getJson",
        data: "{ time:'" + sum + "' }",
        type: "POST",
        dataType: "json",
        async: true,
        contentType: "application/json; charset=utf-8",
        success: function (data) { },
        error: function () { }

    });

}