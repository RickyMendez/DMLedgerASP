function addHelper (url, model, table, form) {
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

function editBankHelper(url, updatedData, col, table) {
    $(document).ready(function () {
        var model = {};
        switch (col) {
            case 0:
                model = {
                    id: table.data()[0].id,
                    name: updatedData,
                    balance: table.data()[0].balance
                };
                break;
            case 1:
                model = {
                    id: table.data()[0].id,
                    name: table.data()[0].name,
                    balance: updatedData
                };
                break;
            default:
                break;
        }

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
    });
}
