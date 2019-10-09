 $(document).ready(function () {
        $("#selectFor").change(function () {
            var selectFor = $(this).val();
        $("#txtSearch").keyup(function () {
            var txtEnter = $(this).val();
            $("table tr").each(function (results) {
                if (results != 0) {
                    var id = $(this).find("td" +selectFor).text();
                    if (id.indexOf(txtEnter) !== 0 && id.toLowerCase().indexOf(txtEnter.toLowerCase()) < 0) {
                        $(this).hide();
                    }
                    else {
                        $(this).show();
                    }
                }
            });
        });
        });
    
    });