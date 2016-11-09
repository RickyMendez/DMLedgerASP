function addHelper(url, model, table, form) {
    $.post(url, model)
    .done(function () {
        toastr.success("Added successfully!");
        form.find("input[type=text]").val("");
        form.find("input[type=date]").val("");
        table.ajax.reload();
    })
    .fail(function () {
        toastr.error("Something went wrong!")
    });
}
function editHelper(url, model, table) {
    $.ajax({
        type: 'put',
        url: url,
        data: model,
        success: function () {
            toastr.success("Update successfull!");
            table.ajax.reload();
        }
    }).fail(function () {
        toastr.error("Something went wrong!")
    });
}
function colTotalHelper (api, col) {
    var intVal = function (i) {
        return typeof i === 'string' ?
            i.replace(/[\$,]/g, '') * 1 :
            typeof i === 'number' ?
            i : 0;
    };
    total = api
        .column(col)
        .data()
        .reduce(function (a, b) {
            return intVal(a) + intVal(b);
        }, 0);

    return total;
};
