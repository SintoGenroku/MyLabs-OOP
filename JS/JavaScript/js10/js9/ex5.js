const canv= document.querySelector('.canv');
const bttn = document.querySelector('button');
const inputs = document.querySelectorAll('input');


const width = screen.width;
const height = screen.height;
const x0 = width / 2;
const y0 = height / 2;
const kx = 30;
const ky = 100;

bttn.addEventListener('click', () => {
    inputs.forEach((item, i) => {
        if (item.checked) {
            if (i == 0) {
                canv.innerHTML = '';
                first();
            } else if (i == 1) {
                canv.innerHTML = '';
                sec();
            } else if (i == 2) {
                canv.innerHTML = '';
                third();
            } else if (i == 3) {
                canv.innerHTML = '';
                fourth();
            }
        }
    });
});

function first(){

    const color = $('#list').val();
    for (let x = -2.5; x < 2.5; x = x + 0.01) {
        let y = Math.pow(x, 2);
        canv.innerHTML += `<div style='left: ${(x0 + kx * x - 1)}px; top: ${(y0 - ky * y + 3)}px; background-color: ${color}; width: 5px; height: 6px;'></div>`;
    }
}

function sec(){ 

    const color = $('#list').val();
    for (let x = -1.614; x < 1.8; x = x + 0.005) {
        let y = Math.pow(x, 3);
        canv.innerHTML += `<div style='left: ${(x0 + kx * x - 1)}px; top: ${(y0 - ky * y + 3)}px; background-color: ${color};width: 5px; height: 6px;'></div>`;
    }
}

function third(){
    const color = $('#list').val();
    for (let x = -35; x < 34.5; x = x + 0.14) {
        let y = Math.sin(x);
        canv.innerHTML += `<div style='left:${x0 + kx * x}px; top: ${y0 - ky * y/2 + 3}px; background-color: ${color};width: 8px; height: 8px;'></div>`;
    }
}

function fourth(){
    const color = $('#list').val();
    for (let x = -35; x < 34.5; x = x + 0.14) {
        let y = Math.cos(x);
        canv.innerHTML += `<div style='left: ${x0 + kx * x}px ;top: ${y0 - ky * y/2 + 3}px ;background-color: ${color};width: 8px; height: 8px;'></div>`;
    }
}