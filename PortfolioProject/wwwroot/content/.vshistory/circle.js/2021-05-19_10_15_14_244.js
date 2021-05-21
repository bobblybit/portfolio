document.addEventListener('DOMContentLoaded', () => {
    let mousePosX = 0,
        mousePosY = 0,
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
    var txt = 'hello i am Solomon Young  a fullstack Developer :) ';
    var speed = 70;

   function typeWriter() {
        if (i < txt.length) {
            document.getElementById("typeMessage").innerHTML += txt.charAt(i);
            i++;
            setTimeout(typeWriter, speed);
        }
    }
    typeWriter();
    setInterval(function () { document.getElementById("typeMessage").innerHTML = "";  typeWriter(); } , 10000);










    function changecolor() {
        document.getElementById("typeMessage").style.color = "#fff";
    }

    typeWriter();
    myVar = setInterval(typeWriter, 10000);

    //var typed = new Typed(".typeMessage", {
    //    strings: ["HEllo i am young"]
    //});

});

