let studentsList;
let table = document.querySelector('table');
let bttn = document.querySelector('#submit');

function processFiles(files) {
        let file = files[0];
        const reader = new FileReader();
        reader.readAsText(file);
        reader.onload = function(e) {
            let xml = e.target.result; // строка
            let xmlDOC; // будущий xml
            if (DOMParser) {
                const parser = new DOMParser();// парсер для всех браузеров кроме IE
                xmlDOC = parser.parseFromString(xml, "application/xml");
            } else {
                xmlDOC = new ActiveXObject("Microsoft.XMLDOM");//парсер для IE
                xmlDOC.async = false;
                xmlDOC.loadXML(xml);
            }
            studentsList = xmlDOC.querySelectorAll("Student");
        console.log(studentsList);
        studentsList.forEach((item, i) => {
            document.querySelector('select').innerHTML += `<option>${i}</option>`;
        });
       
    };
}

bttn.addEventListener('click', ()=> {
    let i = document.querySelector('select').value;
    const studentName = studentsList[i].querySelector("Name").innerHTML;
    const studentSurName = studentsList[i].querySelector("Surname").innerHTML;
    const IQ = studentsList[i].querySelector("Score").innerHTML;
    const Birth = studentsList[i].querySelector("BirthDate").innerHTML;
    
    table.innerHTML += `
            <tr>
            <td>${studentName}</td>
            <td> ${studentSurName}</td>
            <td> ${IQ}</td>
            <td> ${Birth}</td>
            </tr>`;
            
})