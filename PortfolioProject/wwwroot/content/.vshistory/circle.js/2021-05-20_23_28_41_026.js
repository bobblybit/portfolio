document.addEventListener('DOMContentLoaded', () => {
    let mousePosX = 1130,
        mousePosY = 465,
        mouseCircle = document.getElementById('mouse-circle');

    document.onmousemove = (e) => {
        mousePosX = e.pageX;
        mousePosY = e.pageY;
    }

    let delay = 6,
        revisedMousePosX = 0,
        revisedMousePosY = 0;

    function delayMouseFollow() {
        requestAnimationFrame(delayMouseFollow);

        revisedMousePosX += (mousePosX - revisedMousePosX) / delay;
        revisedMousePosY += (mousePosY - revisedMousePosY) / delay;

        mouseCircle.style.top = revisedMousePosY + 'px';
        mouseCircle.style.left = revisedMousePosX + 'px';
    }
    delayMouseFollow();
});


$(document).ready(function () {

    var i = 0;
    var txt = "Proficint In The Following";
    var speed = 70;

    function typeWriter() {
        if (i < txt.length) {
            document.getElementById("proficient-intro").innerHTML += txt.charAt(i);
            i++;
            setTimeout(typeWriter, speed);
        }

    }
});


$(document).ready(function () {
    $("#typed3").typed({
        strings: [
            "A Full Stack Web '<' Developer/'>'",
            "And A Designer :)"
        ],
        typeSpeed: 110, // typing speed
        backDelay: 3000, // pause before backspacing
        loop: true
    });
});
