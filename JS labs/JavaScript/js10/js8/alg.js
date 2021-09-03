function wordColor(){
  document.body.innerHTML = '<span class="toChange" font="blue"> Разноцветный текст, ммм, красота </span>';
    $('.toChange').mouseover(function(){$('.toChange').css('color','violet')});
    $('.toChange').mouseout(function(){$('.toChange').css('color','blue')}); 
}

 function newFont(){
    document.body.innerHTML = '<h2 class="toChange"> Меняюсь по щелчку </h2>';
    $('.toChange').click(function(){$('.toChange').css('fontSize','250%')}); 
  } 

  function PictToPict(){
    document.body.innerHTML = '<div id="toChange"><h2>Прокачай своего сквидвварда!</h2><img src="SkinnySkvidy.jpg"></div>';
    $('#toChange').click(function(){$('#toChange').html('<img src="skvidvard.png">')});  
  }

  function transformToPict(){
    document.body.innerHTML = '<div id="toChange"> <h2>Кликни и увидишь красоту</h2> </div>';
    $('#toChange').click(function(){
      $('#toChange').html('<img src="skvidvard.png">');
    });  
    
  }

  function Flex(){
     document.body.innerHTML = `<img id='toChange' src="SkinnySkvidy.jpg" height='100px'>`;
    $('#toChange').mouseover(function(){$('#toChange').css('width','500px')});
    $('#toChange').mouseout(function(){$('#toChange').css('width','150px')}); 
  }

  function Frame(){
    document.body.innerHTML = '<p><font size="6">Рамка после дабл клика</font></p>';
    $('p').dblclick(function(){$('p').css('border','thick outset purple')});
  }