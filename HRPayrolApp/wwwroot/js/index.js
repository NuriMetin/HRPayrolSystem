$(document).ready(function () {

    $("#signIn").click(function () {
        $("#signInElements").css({ "display": "block" });
        $("#signInElements").animate({ top: '5%' });
        $("#signUpElements").css({ "display": "none" });
        $("#signUpElements").animate({ top: '0' });
    });

    $("#signInClose").click(function () {
        $("#signInElements").css({ "display": "none" });
        $("#signInElements").animate({ top: '0' });
    });


    // sign in elements ended

    // sign up elements started
    $("#signUp").click(function () {
        $("#signUpElements").css({ "display": "block" });
        $("#signUpElements").animate({ top: '5%' });

        $("#signInElements").css({ "display": "none" });
        $("#signInElements").animate({ top: '0' });
    });

    $("#signUpClose").click(function () {
        $("#signUpElements").css({ "display": "none" });
        $("#signUpElements").animate({ top: '0' });
    });

};
  