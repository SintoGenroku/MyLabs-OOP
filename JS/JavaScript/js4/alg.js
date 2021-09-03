function Group(number, specialty, quantity) {
   this.number    = number;
   this.specialty = specialty;
   this.quantity  = quantity;

   this.add_stud  = function add_stud(k){
         this.quantity += k;
         document.write("В группу №"+ this.number +" зачислено " + k + " студентов <br>" );
   }
   this.sub_stud  = function sub_stud(k){
         this.quantity -= k;
         document.write("В группе №"+ this.number +" исключено " + k + "студентов <br>" );

   }
   this.ShowInfo = function ShowInfo(){
         document.write("<hr>Группа №" + this.number + "<br>");
         document.write("Специальность " + this.specialty + "<br>");
         document.write("Кол-во студентов " + this.quantity + "<br>");


   }
   
}


function Student(name, surname, physics, matem, it){
      this.name = name;
      this.surname = surname||sosi;
      this.physics = physics;
      this.matem = matem;
      this.it = it;
      this.mark = ((physics+matem+it)/3).toFixed(2); 

      this.AlertInfo = () => {
            alert(name + "  " + surname);
      }

      this.ShowInfo = function ShowInfo(){
            document.write("<hr>" + this.surname+ " " + this.name + "<br>");
            document.write("Курс: " + this.course + "<br>");
            document.write("Физика: " + this.physics + "<br>");
            document.write("Математика: " + this.matem + "<br>");
            document.write("Информатика: " + this.it + "<br>");
            document.write("Средний балл: " + this.mark + "<br>");
   
   
      }
}

const gr1 = new Group(2, 'ИСИТ', 28);
const gr2 = new Group(8, 'ПОиМБС', 25);
const gr3 = new Group(5, 'ПОИТ', 31);
const gr4 = new Group(10, 'ДЭВИ', 27);



function ex1(){
      
     
    
   gr1.add_stud(7);
   gr1.sub_stud(5);
   gr1.ShowInfo();
   gr2.ShowInfo();
   gr3.ShowInfo();
   gr4.ShowInfo();
   console.log(gr1 instanceof String);
   console.log(gr1 instanceof Object);

}

Student.prototype.course = this.course;

      const valera = new Student('Валера', 'Жмышенкко', 6, 6, 9);
      const jorik = new Student('Жора', 'Вуйчич', 7, 4, 8);
      const billy = new Student('Билли', 'Харрингтон', 9, 7, 6);

function ex2(){
  
      valera.course=1;
      jorik.course=2;
      billy.course=3;
      
      billy.AlertInfo();
      
      valera.ShowInfo();
      jorik.ShowInfo();
      billy.ShowInfo();

     
      
}  

function five(){
      return 5;
}

function ex3(){

      Arr = new Array();
      Arr = ["pow", "pop", "push", "shift", "round", "floor", "slice", "sort"]; 
      document.write("Исходный массив:<br>");
      for(i = 0; i < Arr.length;i++) {
            document.write(Arr[i] + " ");
                
        }
      document.write("<br><br>Массив без элемента [3]:<br>");
        delete Arr[3];
        for(i = 0; i < Arr.length;i++) {
            document.write(Arr[i] + " ");
                
        }
        if(2 in Arr)
            document.write("<br>У массива есть элемент №2<br>");
    
        else document.write("<br>У массива нет элемента №2 <br>");

        console.log(Arr instanceof Object);
        console.log(Arr instanceof String);
        console.log(Arr instanceof Array);

document.write(typeof five + "<br>");
document.write(typeof Arr + "<br>");
document.write(typeof Student + "<br>");
document.write(typeof gr1 + "<br>");
document.write(typeof Student.name + "<br>");
document.write(typeof gr1.quantity + "<br>");
document.write(typeof valera.ShowInfo + "<br>");





document.write("<br> У студента есть фамилия: " + `${"surname" in valera}`+"<br>");

}

