function ex2(){
    let a =+prompt("Введите a:", 0);
    let b =+prompt("Введите b:", 0);
    document.write("<table cellspacing=0 border=6px style='border: 3px solid #734';>");
    for(i=0;i<a;i++){

        document.write("<tr>");
        for(m=0;m<b;m++){

        document.write("<td width=50px height=50px style='text-align: center; background-color: #73F789'>"+(i+1)*(m+1)+"</td>");
        }

        document.write("</tr>");
    }
    document.write("</table>");
}


function ex3(){
    let a =+prompt("Введите a:", 0);
    let b =+prompt("Введите b:", 0);
    document.write("<table cellspacing=0 border=6px style='border: 3px solid #734'>");
    document.write("<tr>");
        document.write("<td>" + "Радиус"+ "</td> ");
        document.write("<td>"+" Площадь круга "+"</td>");
        document.write("<td>"+" Длина окружности"+" </td>");
    document.write("</tr>");
    do{
        x =Math.PI*Math.pow(a,2);
        y = 2*Math.PI*a; 
        document.write("<tr>");
        document.write("<td>"+a+"</td>");
        document.write("<td>"+Math.round(x)+"</td>");
        document.write("<td>"+Math.round(y)+"</td>");
        document.write("</tr>");
        a+=0.3;
        
    }
    while(a<=b);
    document.write("</table>");
}

function ex4(){
x = new Number('34.215');
y = new Number('27');
document.write("<table cellspacing=0 border=6px style='border: 3px solid #734'>");

document.write("<tr>");
    document.write("<td>" + "Число"+ "</td> ");
    document.write("<td>"+" Метод "+"</td>");
    document.write("<td>"+" Результат "+" </td>");
    document.write("<td>"+" Описание метода "+" </td>");
document.write("</tr>");   

document.write("<tr>");
    document.write("<td>" + x + "</td> ");
    document.write("<td>"+" toString(16) "+"</td>");
    document.write("<td>"+ x.toString(16)+" </td>");
    document.write("<td>"+" Строковое представление числа в 16-ричной системе счисления "+" </td>");
document.write("</tr>");

document.write("<tr>");
    document.write("<td>" + y + "</td> ");
    document.write("<td>"+" toString(16) "+"</td>");
    document.write("<td>"+y.toString(16)+" </td>");
    document.write("<td>"+" Строковое представление числа в 16-ричной системе счисления "+" </td>");
document.write("</tr>");

document.write("<tr>");
    document.write("<td>" + x + "</td> ");
    document.write("<td>"+" toExponential(5) "+"</td>");
    document.write("<td>"+x.toExponential(5)+" </td>");
    document.write("<td>"+"представляет число в экспоненциальной форме "+" </td>");
document.write("</tr>");

document.write("<tr>");
    document.write("<td>" + y + "</td> ");
    document.write("<td>"+" toExponential(5) "+"</td>");
    document.write("<td>"+y.toExponential(5)+" </td>");
    document.write("<td>"+" представляет число в экспоненциальной форме "+" </td>");
document.write("</tr>");

document.write("<tr>");
    document.write("<td>" + x + "</td> ");
    document.write("<td>"+" toFixed(1) "+"</td>");
    document.write("<td>"+x.toFixed(1)+" </td>");
    document.write("<td>"+" Представляет число в форме с фиксированным количеством цифр по-сле точки "+" </td>");
document.write("</tr>");

document.write("<tr>");
    document.write("<td>" + y + "</td> ");
    document.write("<td>"+" toFixed(1) "+"</td>");
    document.write("<td>"+ y.toFixed(1) +" </td>");
    document.write("<td>"+" Представляет число в форме с фиксированным количеством цифр по-сле точки "+" </td>");
document.write("</tr>");

document.write("<tr>");
    document.write("<td>" + x + "</td> ");
    document.write("<td>"+" toPrecision(2) "+"</td>");
    document.write("<td>"+ x.toPrecision(2)+" </td>");
    document.write("<td>"+" Представляет число с заданным общим количеством значащих цифр "+" </td>");
document.write("</tr>");

document.write("<tr>");
    document.write("<td>" + y + "</td> ");
    document.write("<td>"+" toPrecision(2) "+"</td>");
    document.write("<td>"+y.toPrecision(2)+" </td>");
    document.write("<td>"+" Представляет число с заданным общим количеством значащих цифр "+" </td>");
document.write("</tr>");

document.write("</table>");
}