function ex1(){
  for(i=0; i <(document.body.children.length); i++){
    alert(`Тег:  ${document.body.children[i].tagName}  ${document.body.children[i].nodeType}, номер   ${i+1} `);
  }         
  for(i =0; i <(document.all.length); i++){
    document.write(`Тег:  ${document.all[i].tagName}  , номер   ${i+1} `);
  }     
}

function ex2(){
  let FirstSpan = document.querySelector("span");
  alert(FirstSpan.innerHTML);      
}  


function ex2_1(){
  let  FirstSpan = document.getElementById("#wewe");
  alert(FirstSpan.innerHTML);
}

function ex2_2(){
  let element = document.all;
  for(let tmp of element){
    if(tmp.tagName == "SPAN"){
        alert(tmp.textContent);
        break;
      }
  }
}
  
function ex3_1(){
  let grade = 0;
  let marks = document.querySelectorAll(".mark");
  for(let i = 0; i< marks.length; i++){
      grade +=marks[i].innerHTML; 
  }
   
  alert(`Средний балл: ${grade/marks.length}`)
  
  }