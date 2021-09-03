function ex1() {
    alert("Вас приветствует учебный центр");
    let name=prompt("Введите Ваше имя:", "Имя");
    alert("Здарвствуйте, "+name);
    let awnser = confirm("Хотите стать Web-дизайнером?");
    if (awnser === true)
    document.write ("Учите стили CSS и JavaScript!");
    else
    document.write ("Упускаете время! " +'\n');
    
}

function ex2(){
    let StNum = "22"+5;
    let NumSt = 22+"5";
    document.write (10+5+'\n');
    document.write ("10"+"5"+'\n');
    document.write (StNum+'\n');
    document.write (NumSt+'\n');
    document.write ("Результатом сложения строки и числа всегда будет … " +typeof StNum +"/"+ typeof NumSt + '\n');

}

function ex3(){
    let x=prompt("Введите x:", 0); 
    let y=prompt("Введите y:", 0);
    let solve1 = (1/(-x))*2*y;
    let solve2 = 3*x+12*y;
    alert(solve1);
    alert(solve2);
    alert(solve2%solve1);
    document.write(solve1%solve2);
}

function ex4(){
    let number=prompt("Введите число:", "0"); 
    if(number < 20 || number > 40 && number!=15 && number%5==0){
        alert("Правильное значение");
        document.write ("Правильное значение");
    }
    else{   
        alert("Неправильное значение");
        document.write ("Неправильное значение");
    }
}
function ex5(){
    let FirstLetter=prompt("Введите первую строку:", " ");
    let SecLetter=prompt("Введите вторую строку:", " ");
    (FirstLetter>=SecLetter)?alert("строка 1 длиннее"):alert("строка 2 длиннее");

    let A=prompt("Введите число А:", "0");
    let B=prompt("Введите число Б:", "0");
    if(B>A)
        document.write ("Б больше чем А");
    else if(A>B)
        document.write ("А больше чем Б");
    else
        document.write ("А и Б равны");

}

function ex6(){
    const tday = new Date();
        switch(tday.getDay()){
        case 1: 
            alert("Сегодня понедельник!");
            break;
        case 2: alert("Сегодня вторник!");
            break;
        case 3: 
            alert("Сегодня среда!");
            break;
        case 4: 
            alert("Сегодня четверг!");
            break;
        case 5: 
            alert("Сегодня пятница!");
            break;
        case 6: 
            alert("Сегодня суббота!");
            break;
        case 0: 
            alert("Сегодня воскресенье!");
            break;
    }
}

function ex7(){
    try {
        alert('Начало блока');
        fififi; // ошибка, переменная не определена
        alert('Конец блока');
        } catch(e) {
        alert('Ошибка ' + e.name + ":" + e.message);
        }
        alert("Код продолжает выполнение");
        
}