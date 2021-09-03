


let op = [];
const btns = document.querySelectorAll('button');
btns.forEach((item, i)=> {
  item.addEventListener('click', () => {
    if (i === 0){
      let alias = prompt('Введите имя окна:', 'имя' );
      op[op.length] =  window.open('about:blank', `${alias}`, 'width=750px, height=600px');
      console.log(op);
    } else if (i === 1){
      let alias = prompt('Введите имя окна:', 'имя' );
      op.forEach(element => {
        if(alias === element.name){
          element.close();
          op = op.filter(item => item.name !== alias)
        }
      });
      } else if (i === 2){
        let alias = prompt('Введите имя окна:', 'имя' );
        op.forEach(element => {
          if(alias === element.name){
            element.document.body.innerHTML = `Hello World! Im ${element.name}`;
          }
        });
      }
    })
  });


 
document.write("<table cellspacing=0 border=6px style='border: 3px solid #734'>");

  document.write("<tr>");
      document.write("<td> Свойство </td> ");
      document.write("<td> Значение </td>");
  document.write("</tr>");   
  
  document.write("<tr>");
      document.write(`<td> navigator.userAgent  </td> `);
      document.write(`<td> ${navigator.userAgent} </td>`);
  document.write("</tr>");
  
  document.write("<tr>");
      document.write(`<td> navigator.appVersion  </td> `);
      document.write(`<td> ${navigator.appVersion} </td>`);
  document.write("</tr>");
  
  document.write("<tr>");
      document.write(`<td> navigator.appName  </td> `);
      document.write(`<td> ${navigator.appName} </td>`);  
  document.write("</tr>");
  
  document.write("<tr>");
      document.write(`<td> navigator.appCodeName  </td> `);
      document.write(`<td> ${navigator.appCodeName} </td>`);   
  document.write("</tr>");
  
  document.write("<tr>");
      document.write(`<td> navigator.platform  </td> `);
      document.write(`<td> ${navigator.platform} </td>`);   
  document.write("</tr>");
  
  document.write("<tr>");
      document.write(`<td> history  </td> `);
      document.write(`<td> ${history.length} </td>`);   
  document.write("</tr>");
  
  document.write("<tr>");
      document.write(`<td> navigator.javaEnabled()  </td> `);
      document.write(`<td> ${navigator.javaEnabled()} </td>`);    
  document.write("</tr>");
  
  document.write("<tr>");
      document.write(`<td> screen.height  </td> `);
      document.write(`<td> ${screen.height} </td>`);     
  document.write("</tr>");

  document.write("<tr>");
      document.write(`<td> screen.width  </td> `);
      document.write(`<td> ${screen.width} </td>`);     
  document.write("</tr>");
  
  document.write("<tr>");
      document.write(`<td> screen.colorDepth  </td> `);
      document.write(`<td> ${screen.colorDepth} </td>`);     
  document.write("</tr>");
  

  document.write("<tr>");
    document.write(`<td> location.href </td> `);
    document.write(`<td> ${location.href} </td>`); 
  document.write("</tr>");

  document.write("<tr>");
    document.write(`<td> location.pathname </td> `);
    document.write(`<td> ${location.pathname} </td>`); 
  document.write("</tr>");

  document.write("<tr>");
    document.write(`<td> location.host </td> `);
    document.write(`<td> ${location.host} </td>`); 
  document.write("</tr>");

  document.write("</table>");
