<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
   <xsl:template match="/">
      <html>
         <body>
            <h2>СПЕЦИАЛЬНОСТЬ ИСиТ В РАЗЛИЧНЫХ ВУЗАХ</h2>
            <table border="1">
               <tr bgcolor="#9acd32">
                  <td style="text-align:center">Название ВУЗа</td>
                  <td style="text-align:center">Проходной балл</td>
                  <td style="text-align:center">Кол-во мест</td>
                  <td style="text-align:center">Город</td>
               </tr> 
               <xsl:for-each select="FACULTY/SPECIALIZATION">
                  <tr>
                     <td><xsl:value-of select="NAME" /></td>
                        <td><xsl:value-of select="MARK" /></td>
                        <td><xsl:value-of select="OPACITY" /></td>
                        <td><xsl:value-of select="CITY" /></td>
                  </tr>
               </xsl:for-each>
            </table> 
         </body>
      </html>
   </xsl:template>
</xsl:stylesheet> 
