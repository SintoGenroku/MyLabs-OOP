let newWin;
let select = document.querySelector(".list");

function printer(){
  newWin =  window.open('about:blank', 'Panama', 'width=750px, height=600px');
  newWin.document.body.innerHTML += `<h2 align=center><B><u>${document.forms.blank.fac.value}}</u></B></h2></br>Студент   <u>${document.forms.blank.surname.value}   ${document.forms.blank.firstname.value}</u>  специальность <u>${select.value}</u> курс <u>${document.forms.blank.year.value}</u> должен сдавать следующие предметы: </br><ul>`;
  document.querySelectorAll('.check').forEach(item => item.checked ? newWin.document.body.innerHTML += `<li><u> ${item.value} </u></li>`: '');
  newWin.document.body.innerHTML += `</ul>`;
  newWin.print();
}

function NewForm(){
  newWin =  window.open('about:blank', 'Panama', 'width=750px', 'height=600px');
  newWin.document.body.innerHTML = '<form><fieldset><legend> Вторая форма </legend><select>';
  document.querySelectorAll('.check').forEach(item => item.checked ? newWin.document.querySelector('select').innerHTML += `<option> ${item.value} </option>`: '');
  newWin.document.body.innerHTML +='</select></fieldset></form>';
}