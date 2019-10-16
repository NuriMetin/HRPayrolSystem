function showImage() {
    if (this.files && this.files[0]) {
        var obj = new FileReader();
        obj.onload = function (data) {
            var image = document.getElementById("image");
            image.src = data.target.result;
        }
        obj.readAsDataURL(this.files[0]);
    }
}
////---------------Load salary--------------------
$(function () {
    $(window).scroll(function () {
        if ($(window).height() + Math.ceil($(document).scrollTop()) >= $(document).height()) {
            var skipcount = +$(".skipcount").val();
            var totalcount = $("#totalCount").val();
            if (skipcount <= totalcount) {
                $.ajax({
                    url: "/AJAX/LoadSalary",
                    type: "Get",
                    data: { skip: skipcount },
                    success: function (res) {
                        $("#forappend").append(res);
                        $(".skipcount").val(skipcount + 2)
                    }
                });
            }
        }
    });
});


//----------------------------LoadEmployee-----------------------
$(function () {
    $(window).scroll(function () {
        if ($(window).height() + Math.ceil($(document).scrollTop()) >= $(document).height()) {
            var skip= +$(".skip").val();
            var total = $("#total").val();
            if (skip <= total) {
                $.ajax({
                    url: "/AJAX/LoadEmployee",
                    type: "Get",
                    data: { skip: skip },
                    success: function (mm) {
                        $("#append").append(mm);
                        $(".skip").val(skip + 2)
                    }
                });
            }
        }
    });
});

//----------------------Load Bank WorkerList----------------
$(function () {
    $(window).scroll(function () {
        if ($(window).height() + Math.ceil($(document).scrollTop()) >= $(document).height()) {
            var bankSkipCount = +$(".bankSkipCount").val();
            var bankTotalCount = $("#bankTotalCount").val();
            if (bankSkipCount <= bankTotalCount) {
                $.ajax({
                    url: "/AJAX/LoadBankAccount",
                    type: "Get",
                    data: { skip: bankSkipCount },
                    success: function (tt) {
                        $("#bankAppend").append(tt);
                        $(".bankSkipCount").val(bankSkipCount + 2)
                    }
                });
            }
        }
    });
});


//----------------------Load StoreBonus----------------

//----------------------Load BonusWorkerList----------------
$(function () {
    $(window).scroll(function () {
        if ($(window).height() + Math.ceil($(document).scrollTop()) >= $(document).height()) {
            var bonusWorkersSkipCount = +$(".bonusWorkersSkipCount").val();
            var bonusWorkersTotalCount = $("#bonusWorkersTotalCount").val();
            if (bonusWorkersSkipCount <= bonusWorkersTotalCount) {
                $.ajax({
                    url: "/AJAX/LoadBonusWorkerList",
                    type: "Get",
                    data: { skip: storeBonusSkipCount },
                    success: function (ii) {
                        $("#bonusWorkersAppend").append(ii);
                        $(".bonusWorkersSkipCount").val(bonusWorkersSkipCount + 2)
                    }
                });
            }
        }
    });
});

//----------------------Load DepartmentList----------------
$(function () {
    $(window).scroll(function () {
        if ($(window).height() + Math.ceil($(document).scrollTop()) >= $(document).height()) {
            var departmentListskipcount = +$(".departmentListskipcount").val();
            var bonusWorkersTotalCount = $("#bonusWorkersTotalCount").val();
            if (departmentListskipcount <= bonusWorkersTotalCount) {
                $.ajax({
                    url: "/AJAX/LoadDepartmentList",
                    type: "Get",
                    data: { skip: departmentListskipcount },
                    success: function (res) {
                        $("#bonusWorkersAppend").append(res);
                        $(".departmentListskipcount").val(departmentListskipcount + 2)
                    }
                });
            }
        }
    });
});


//----------------------Load DepartmentList----------------
$(function () {
    $(window).scroll(function () {
        if ($(window).height() + Math.ceil($(document).scrollTop()) >= $(document).height()) {
            var calcSalSkipcount = +$(".calcSalSkipcount").val();
            var calcSalTotalCount = $("#calcSalTotalCount").val();
            if (calcSalSkipcount <= calcSalTotalCount) {
                $.ajax({
                    url: "/AJAX/LoadCalculateSalary",
                    type: "Get",
                    data: { skip: calcSalSkipcount },
                    success: function (res) {
                        $("#calcSalAppend").append(res);
                        $(".calcSalSkipcount").val(calcSalSkipcount + 2)
                    }
                });
            }
        }
    });
});

//----------------------Load Workers----------------
$(function () {
    $(window).scroll(function () {
        if ($(window).height() + Math.ceil($(document).scrollTop()) >= $(document).height()) {
            var workerSkipcount = +$(".workerSkipcount").val();
            var workerTotalCount = $("#workerTotalCount").val();
            if (workerSkipcount <= workerTotalCount) {
                $.ajax({
                    url: "/AJAX/LoadWorkers",
                    type: "Get",
                    data: { skip: workerSkipcount },
                    success: function (res) {
                        $("#workerAppend").append(res);
                        $(".workerSkipcount").val(workerSkipcount + 2)
                    }
                });
            }
        }
    });
});