function ex1(){
    let equation = new Array();
    equation[0] = 6*(Math.pow(Math.PI, 2)) + 3*Math.exp(8);
    equation[1] = 2*Math.cos(4) + Math.cos(12) + 8*Math.exp (8);
    equation[2] = 3*Math.sin(9) + Math.log(5) + Math.sqrt(3);
    equation[3] = 2*Math.tan(5) + 6*Math.PI + Math.sqrt(12);
 
    let biggest = maxArr(equation);
    let smallest = minArr(equation);
    
    document.write("Max: " + biggest + "<br>");
    document.write("Min: "+ smallest + "<br>");

for(i = 0; i < equation.length; i++){

    if(equation[i]=== biggest)
    document.write("index of Max: " + i +"<br>");

    if(equation[i]=== smallest)
    document.write("index of Min: " + i +"<br>");

}
function maxArr(arr)
{
    let max = arr[0];
    for(let tmp of arr){
        if(max < tmp){
            max = tmp
        }
    }
    return max;
}

function minArr(arr)
{
    let min = arr[0];
    for(let tmp of arr){
        if(min > tmp){
            min = tmp
        }
    }
    return min;
    }
}




function ex2(){
  

    UnArr = new Array();
    Matem = new Array();
    Arr = new Array();
    UnArr[0] = "pow"; // число в степень
    UnArr[1] = "pop"; // удалить последний элемент
    UnArr[2] = "push"; // добавить указанное значение в конец
    UnArr[3] = "shift"; // удалить первый элемент
    UnArr[4] = "round"; // округление
    UnArr[5] = "floor"; // округление вниз
    UnArr[6] = "slice"; // создать массив из указанного диапазона
    UnArr[7] = "sort"; // сортировка по выбранной функции

    document.write("<hr>UnArr: <br><br>");
    
        for(i = 0; i < UnArr.length;i++) {
            document.write(UnArr[i] + "<br>");
                
        }
    document.write("Длина:" + UnArr.length + "<br>");
    
    for(i = 0; i < UnArr.length; i++) {

        if(UnArr[i] in Math){
            Matem[Matem.length] = UnArr[i];
        } 
        if(!(UnArr[i] in Math)) {
            Arr[Arr.length] = UnArr[i];
        }
    }
    Matem.push("pow");  
    Arr.unshift("concat");
    document.write("<hr>Math: <br>");

    for(i = 0; i < Matem.length; i++) {
        document.write(Matem[i] + "<br>");
    }  
    document.write("Длина: " + Matem.length + "<br>");
      
    
    document.write("<hr>Array:<br><br>");

    for(i = 0; i < Arr.length; i++) {
        document.write(Arr[i] + "<br>");
    }  
    document.write("Длина: " + Arr.length + "<br>");
}  


function ex3(){

    var str = "Борозда Андрей Сергеевич";
   
    
    let UpReg = str.toUpperCase();
    let LowReg = str.toLowerCase();
    let Sum = new String;
   
    document.write(str + "<br>");
    document.write(UpReg + "<br>");
    document.write(LowReg + "<br>");
    Sum = Sum.concat(UpReg,LowReg);
    document.write(Sum + "<br>");

    str = str.replace("Борозда","Б");
    str = str.replace("Андрей","А");
    str = str.replace("Сергеевич","С");

    document.write(str);
}


function ex4(){

    const tday = new Date();
    document.write("<table cellspacing=0 border=6px style='border: 3px solid #734'>");

    document.write("<tr>");
        document.write("<td>" + "Год"+ "</td> ");
        document.write("<td>"+tday.getFullYear()+"</td>");
    document.write("</tr>");   
    
    document.write("<tr>");
        document.write("<td>" + "Месяц" + "</td> ");
        document.write("<td>"+ `${tday.getMonth() +1}` +"</td>");
    document.write("</tr>");
     
    document.write("<tr>");
        document.write("<td>" + "День" + "</td> ");
        document.write("<td>"+  tday.getDate() +"</td>");
    document.write("</tr>");

    document.write("<tr>");
        document.write("<td>" + "Час" + "</td> ");
        document.write("<td>"+ tday.getHours() +"</td>");
    document.write("</tr>");

    document.write("<tr>");
        document.write("<td>" + "Минуты" + "</td> ");
        document.write("<td>"+ tday.getMinutes() +"</td>");
    document.write("</tr>");

    document.write("<tr>");
        document.write("<td>" + "Секунды" + "</td> ");
        document.write("<td>"+  tday.getSeconds() +"</td>");
    document.write("</tr>");

    document.write("</table>");

}