var dataTable;
$(document).ready(function () {
    dataTable = $('#tblData').dataTable({
        "ajax": {
            url: "/order/getall"  // order è il nome del OrderController and getall del ActionMethod!!!
        },
        "columns": [
            { data: 'orderheaderid', "width": "5%"},  // orderheaderId è il nome della columns indice nella tabella OrderHeaderDto!!!
            { data: 'email', "width": "25%"} // sempre dalla OrderHeaderId il campo email
        ]
    })
})