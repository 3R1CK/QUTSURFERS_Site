$(document).ready(function () {
    var table = $("#members").DataTable({
        ajax: {
            url: "/api/members/",
            dataSrc: ""
        },
        columns: [
            {
                data: "studentNumber"
            },

            {
                data: "firstName",
                render: function (data, type, member) {
                    return "<a href='/members/edit/" + member.id + "'>" + member.firstName + " " + member.lastName + "</a>";
                }
            },
           
            {
                data: "email"
            },
            {
                data: "phoneNumber"
            },
            {
                data: "intlStudent"
            },

            {
                data: "surfingLevel.name"
            },
            {
                data: "paymentType.name"
            },
            {
                data: "paymentApproval",
                render: function (data, type, member) {
                    if (data == true) {
                        return "<a class='btn btn-xs btn-success' href='#" + member.id + "'>Confirmed</a>";
                    } else {
                        return "<a class='btn btn-xs btn-danger' href='#" + member.id + "'>Pending</a>";
                    }

                }
            }
        ]
    });

    $("#members .js-approve").on("click",
        function () {
            confirm("Are you sure you want to confirm this payment?");
        });
});