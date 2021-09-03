let canvas = document.getElementById("draw");
let x=canvas.getContext("2d");
let img = document.querySelector('img');
let grad =x.createLinearGradient(390, 350, 480, 600); 
grad.addColorStop(0,'violet'); 
grad.addColorStop(1,'lightblue');

x.fillStyle='PaleGreen';
x.fillRect(80, 200, 470, 400);

x.fillStyle="green";
x.LineWidth="4";
x.moveTo(80, 600); 
x.lineTo(550, 600); 
x.stroke();
x.moveTo(80, 200); 
x.lineTo(80, 600); 
x.stroke();

x.font='15px Verdana'; 
x.fillStyle='#60016d';
x.fillText("Чево делаеш", 510,620);
x.fillText("Время, ч", 3,210);
x.fillText("0", 70,620);
x.fillStyle = x.createPattern(img, 'repeat');
x.fillRect(130, 400, 70, 199);
x.fillStyle='SteelBlue';
x.fillRect(260, 300, 70, 299); 
x.fillStyle=grad;
x.fillRect(390, 350, 70, 249);

x.fillStyle='MidnightBlue';
x.fillText("Досуг", 140,615);
x.fillText("Учеба", 270,615);
x.fillText("Отдых", 400,615);


function drawPieSlice(obj,centerX, centerY, radius, startAngle, endAngle, color ){
    obj.fillStyle = color;
    obj.beginPath();
    obj.moveTo(centerX,centerY);
    obj.arc(centerX, centerY, radius, startAngle, endAngle);
    obj.closePath();
    obj.fill();
    obj.strokeStyle="PapayaWhip";
    obj.lineWidth = "10 ";
    obj.stroke();
}
function MetaInfo( obj, colors){
    let cordY = 150, cordX = 1200;
    colors.forEach(element => {
        obj.fillStyle = element;
        obj.fillRect(cordX, cordY,10, 10);
        obj.fillText(element, cordX+20, cordY+10);
        cordY+=35;
    });
}
x.beginPath();
x.fillStyle ='PapayaWhip';
x.arc(900, 400, 270, 0, Math.PI*2);
x.fill();
x.closePath();
let colors= ['BurlyWood', 'LightSalmon', 'SandyBrown', 'Peru'] 
drawPieSlice(x, 900, 400, 250, 0, Math.PI*0.8, 'BurlyWood');
drawPieSlice(x, 900, 400, 250, Math.PI*0.8, Math.PI*1.1, 'LightSalmon');
drawPieSlice(x, 900, 400, 250,  Math.PI*1.1, Math.PI*1.6, 'SandyBrown');
drawPieSlice(x, 900, 400, 250, Math.PI*1.6, Math.PI*2, 'Peru');
MetaInfo(x,colors);
