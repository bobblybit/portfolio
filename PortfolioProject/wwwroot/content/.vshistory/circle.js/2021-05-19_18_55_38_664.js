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
    $("#typed3").typed({
        strings: [
            "A Full Stack Developer",
            "And A Designer"
        ],
        typeSpeed: 110, // typing speed
        backDelay: 1000, // pause before backspacing
        loop: true
    });
});
