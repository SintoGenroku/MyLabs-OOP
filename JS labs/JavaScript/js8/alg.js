function wordColor(){
  document.body.innerHTML = '<span class="toChange" font="blue"> Разноцветный текст, ммм, красота </span>';
  let target = document.querySelector('.toChange');
  target.onmouseover =  () => {
    target.style.color = 'violet';
  }
  target.onmouseout =  () => {
    target.style.color = 'blue';
  }
}

 function newFont(){
    document.body.innerHTML = '<h2 class="toChange"> Меняюсь по щелчку </h2>';
    let target = document.querySelector(".toChange");
    target.onclick = () => {
      target.style.fontSize = "250%";
    }
  
  } 
  
  function PictToPict(){
    document.body.innerHTML = '<h2>Прокачай своего сквидвварда!</h2><img id=#toChange src="SkinnySkvidy.jpg">';
    let target = document.getElementById("#toChange");
    target.onclick = () => {
      target.src = "skvidvard.png";
    }
  }

  function transformToPict(){
    document.body.innerHTML = '<h2 id=#toChange> Кликни и увидишь красоту </h2>';
    let target = document.getElementById("#toChange");
    target.onclick = () => {
      target.innerHTML = '<img src ="skvidvard.png">';
    }
  }

  function Flex(){
    document.body.innerHTML = '<img id=#toChange src="SkinnySkvidy.jpg" height= 100px>';
    let target = document.getElementById("#toChange");
    target.onmouseover =  () => {
      target.style.width = '60%';
    }
    target.onmouseout =  () => {
      target.style.width = '10%';
    }
  }

  function Frame(){
    document.body.innerHTML = '<p><font size="6">Рамка после дабл клика</font></p>';
    let target = document.querySelector('p');
    console.log(target);
    target.ondblclick = () => {
      target.style.border = 'thick outset purple';
    }
  }