function addHelper(url, model, table, form) {
    $.post(url, model)
    .done(function () {
        toastr.success("Added successfully!");
        form.find("input:text").val("");
        form.find("input:date").val("");
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
