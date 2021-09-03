let head = document.querySelector('header');
let foot = document.querySelector('footer');
let person = document.querySelector('mark');

document.querySelector('button').addEventListener('click', (e) => {
    // e.preventDefault();
    person.innerHTML = `${document.forms.blank.surname.value} ${document.forms.blank.name.value}`
    head.innerHTML += `<h1> ${document.forms.blank.radio.value} курс ${document.forms.blank.group.value} группа</h1><br>`;
    head.innerHTML += `<h2>Контакты:<br> email:${document.forms.blank.email.value}      Телефон: ${document.forms.blank.tel.value}</h2>`;
    foot.innerHTML += '<h2>А это просто футер, в который я не придумал что запихнуть:)</h2>';
});