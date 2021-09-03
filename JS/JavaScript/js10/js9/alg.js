function ex1(){

  document.body.innerHTML = ' <textarea position="relative" class="toDrag"></textarea> <img  src="cube.png" position="relative" class="toDrag"></img>';
    $(".toDrag").draggable();

}

function ex2(){

  document.body.innerHTML = '<img draggable="false" src="cube.png" class="anim"></img>';
  let obj = document.querySelector('.anim');
  const move = () => {
  
    
    $(".anim").animate({left:820},2000);
    $(".anim").animate({left:0},2000);

  };

  obj.addEventListener('click', (event) => {
      const interval = setInterval(move);
  });
}

function ex3(){

  document.body.innerHTML = '<img draggable="false" src="cube.png" class="Drag"></img>';
  const obj = document.querySelector('.Drag');
  
  
  const move = () => {
  
    // $(".Drag").animate({top:220},2000);
    // $(".Drag").animate({left:320},2000);
    // $(".Drag").animate({top:0,left:0},2000);
    
    $(".Drag").animate({
        'left':'+=50px'  
    },{
        duration: 400,
        easing: linear,
        complete: function(){alert("done!")}
    })
  };
  
  obj.addEventListener('click', (event) => {
      interval = setInterval(move);
  });
}