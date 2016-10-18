var addHelper = function (url, model, table, form) {
    $(document).ready(function () {
        $.post(url, model)
        .done(function () {
            toastr.success("Added successfully!");
            form.find("input:text").val("");
            table.ajax.reload();
        })
        .fail(function () {
            toastr.error("Something went wrong!")
        });
    });
};