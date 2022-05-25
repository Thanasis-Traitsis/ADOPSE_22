// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

<<<<<<< Updated upstream
<<<<<<< Updated upstream
//JS for log in
const tl = gsap.timeline({ defaults: { duration: 1 } });

const container = document.querySelectorAll(".login_form-container");
const form = document.querySelector("form");

container.forEach((container) => {
    const input = container.querySelector(".input");
    const placeholder = container.querySelector(".placeholder");

    input.addEventListener("focus", () => {

        if (!input.value) {
            //Placeholder Shift
            tl.to(
                placeholder,
                {
                    top: -15,
                    left: 0,
                    scale: 0.7,
                    duration: 0.5,
                    ease: "Power2.easeOut",
                }
            );
        }
    });
});

//Revert back if it's not focused
form.addEventListener("click", () => {
    container.forEach((container) => {
        const input = container.querySelector(".input");
        const placeholder = container.querySelector(".placeholder");

        if (document.activeElement !== input) {
            if (!input.value) {
                gsap.to(placeholder, {
                    top: 0,
                    left: 0,
                    scale: 1,
                    duration: 0.5,
                    ease: "Power2.easeOut",
                });
            }
        }
    });
});

//JS for sign up
const container2 = document.querySelectorAll(".signup_form-container");

container2.forEach((container) => {
    const input2 = container.querySelector(".signup_input");
    const placeholder = container.querySelector(".placeholder");

    input2.addEventListener("focus", () => {

        if (!input2.value) {
            //Placeholder Shift
            tl.to(
                placeholder,
                {
                    top: -15,
                    left: 0,
                    scale: 0.7,
                    duration: 0.5,
                    ease: "Power2.easeOut",
                }
            );
        }
    });
});
=======
=======
>>>>>>> Stashed changes
/*JS for log in*/
//const tl = gsap.timeline({ defaults: { duration: 1 } });

//const container = document.querySelectorAll(".login_form-container");
//const form = document.querySelector("form");

//container.forEach((container) => {
//    const input = container.querySelector(".input");
//    const placeholder = container.querySelector(".placeholder");

//    input.value == "";

//    input.addEventListener("focus", () => {

//        if (!input.value) {
//            //Placeholder Shift
//            tl.to(
//                placeholder,
//                {
//                    top: -15,
//                    left: 0,
//                    scale: 0.7,
//                    duration: 0.5,
//                    ease: "Power2.easeOut",
//                }
//            );
//        }
//    });
//});

//Revert back if it's not focused
//form.addEventListener("click", () => {
//    container.forEach((container) => {
//        const input = container.querySelector(".input");
//        const placeholder = container.querySelector(".placeholder");

//        if (document.activeElement !== input) {
//            if (!input.value) {
//                gsap.to(placeholder, {
//                    top: 0,
//                    left: 0,
//                    scale: 1,
//                    duration: 0.5,
//                    ease: "Power2.easeOut",
//                });
//            }
//        }
//    });
//});

////JS for sign up
//const container2 = document.querySelectorAll(".signup_form-container");

//container2.forEach((container) => {
//    const input2 = container.querySelector(".signup_input");
//    const placeholder = container.querySelector(".placeholder");

//    input2.addEventListener("focus", () => {

//        if (!input2.value) {
//            //Placeholder Shift
//            tl.to(
//                placeholder,
//                {
//                    top: -15,
//                    left: 0,
//                    scale: 0.7,
//                    duration: 0.5,
//                    ease: "Power2.easeOut",
//                }
//            );
//        }
//    });
//});

////Revert back if it's not focused
//form.addEventListener("click", () => {
//    container2.forEach((container) => {
//        const input2 = container.querySelector(".signup_input");
//        const placeholder = container.querySelector(".placeholder");

//        if (document.activeElement !== input2) {
//            if (!input2.value) {
//                gsap.to(placeholder, {
//                    top: 0,
//                    left: 0,
//                    scale: 1,
//                    duration: 0.5,
//                    ease: "Power2.easeOut",
//                });
//            }
//        }
//    });
//});

//Dropdown menu on navbar
const arrowDown = document.querySelector(".dropdown");
const examMenu = document.querySelectorAll(".exam");

let showMenu = false;
arrowDown.addEventListener('click', () => {
    if (!showMenu) {
        examMenu.forEach((container) => {
            container.style.display = "block";
        })

        showMenu = true;
    }

    else {
        examMenu.forEach((container) => {
            container.style.display = "none";
        })

        showMenu = false;
    }
});


//Taking the value of the Difficulty of the Question ------------> difNumber
const difContainer = document.querySelectorAll(".difficulty-boxes__container");
const difBox = document.querySelectorAll(".difficulty-boxes__box");
const difficulty = document.querySelector("#dif-number");

difContainer.forEach((box) => {
    box.addEventListener('click', (e) => {
        difBox.forEach((container) => {
            container.style.backgroundColor = "";
        })
        e.target.style.backgroundColor = "#7A9E9F";
        var difNumber = e.target.innerHTML;

        difficulty.value = difNumber;
    })
})
>>>>>>> Stashed changes

//Revert back if it's not focused
form.addEventListener("click", () => {
    container2.forEach((container) => {
        const input2 = container.querySelector(".signup_input");
        const placeholder = container.querySelector(".placeholder");

        if (document.activeElement !== input2) {
            if (!input2.value) {
                gsap.to(placeholder, {
                    top: 0,
                    left: 0,
                    scale: 1,
                    duration: 0.5,
                    ease: "Power2.easeOut",
                });
            }
        }
    });
});
