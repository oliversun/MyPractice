
$(function () {
    $('#ddlProvince').change(function () { GetCities(); })
    $('#ddlCity').change(function () { GetCounties(); })
});

function GetCities() {
    var provinceid = $("#ddlProvince").val();

    if (provinceid == "0") {
        $("#ddlCity").empty();
        $("<option value='0' selected='selected'>--请选择--</option>").appendTo($("#ddlCity"))
        return;
    }

    $.ajax({
        type: "GET",
        url: '@Url.Action("GetCities")',//getcities url
        data: { provinceID: provinceid },
        beforeSend: function () {
            $("<option></option>")
        .val('0')
        .text('获取城市数据中')
        .appendTo($("#ddlCity"));
            $("#ddlCity").attr("disabled", 'disabled');
        },
        success: function (data) {
            $("#ddlCity").empty();

            $.each(data, function (i, item) {
                $("<option></option>")
                    .val(item["CityID"])
                    .text(item["CityName"])
                    .appendTo($("#ddlCity"));
            });
            $("#ddlCity").removeAttr('disabled');
            $("#ddlCity").change();
        }
    });
}

function GetCounties() {
    var cityid = $("#ddlCity").val();

    if (cityid == "0") {
        $("#ddlCounty").empty();
        $("<option value='0' selected='selected'>--请选择--</option>").appendTo($("#ddlCounty"))
        return;
    }

    $.ajax({
        type: "GET",
        url: '@Url.Action("GetCounties")',////getcounties url
        data: { cityid: cityid },
        beforeSend: function () {
            $("<option></option>")
        .val('0')
        .text('获取城市数据中')
        .appendTo($("#ddlCounty"));
            $("#ddlCounty").attr("disabled", 'disabled');
        },
        success: function (data) {
            $("#ddlCounty").empty();

            $.each(data, function (i, item) {
                $("<option></option>")
                    .val(item["CountyID"])
                    .text(item["CountyName"])
                    .appendTo($("#ddlCounty"));
            });
            $("#ddlCounty").removeAttr('disabled');

        }
    });
}

//search button click
function Search() {
    var provinceid = $("#ddlProvince").val();
    var cityid = $("#ddlCity").val();
    var countyid = $("#ddlCounty").val();
    if (provinceid == "0" || cityid == "0" || countyid == "0") {
        return;
    }
    var par = '?provinceid=' + provinceid + '&cityid=' + cityid + '&countyid=' + countyid
    window.location = '@Url.Action("display")' + par //redirect to search result page

}