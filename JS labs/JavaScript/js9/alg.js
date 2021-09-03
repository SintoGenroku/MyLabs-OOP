function ex1(){

  document.body.innerHTML = '<textarea draggable="false" class="toDrag"></textarea> <img draggable="false" src="cube.png" class="toDrag"></img>';
    
  let obj = document.querySelectorAll('.toDrag');
  let offsetX;
  let offsetY;

  obj.forEach(item => {
    item.onmousedown = function(event) {
      item.style.position = 'absolute';
      offsetX = event.offsetX;
      offsetY = event.offsetY;
      document.onmousemove = (event) => {
          moveAt(event);
      };
      item.onmouseup = () => {
          document.onmousemove = false;
      };
  };
    const moveAt = (event) => {
      item.style.left = event.pageX - offsetX + 'px';
      item.style.top = event.pageY - offsetY + 'px';
  };
  });
}

function ex2(){

  document.body.innerHTML = '<img draggable="false" src="cube.png" class="anim"></img>';
  let obj = document.querySelector('.anim');
  let curPosX = obj.getBoundingClientRect().left;

  const move = () => {
      obj.style.left = (curPosX++) + "px";
  };

  obj.addEventListener('click', (event) => {
      const interval = setInterval(move);
  });
}

function ex3(){

  document.body.innerHTML = '<img draggable="false" src="cube.png" class="Drag"></img>';
  const obj = document.querySelector('.Drag');
  let curPosX = obj.getBoundingClientRect().left;
  let curPosY = obj.getBoundingClientRect().top;
  let interval;
  let flag = 0;
  
  const move = () => {
  
      curPosX = (!flag) ? curPosX += 2 : curPosX -= 2;
      obj.style.left = `${curPosX}px`;
      obj.style.top = `${Math.cos(curPosX * 0.01) * 100 + curPosY}px`;
      if (curPosX == 1420) {
          flag = 1;
      } else if (curPosX == 200) {
          clearInterval(interval);
          flag = 0;
      }
  };
  
  obj.addEventListener('click', (event) => {
      interval = setInterval(move);
  });
}