<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
   <xsl:template match="/">
      <html>
         <body>
            <h2>Студентики типа</h2>
            <table border="1">
               <tr bgcolor="#9acd32">
                  <td style="text-align:center">Название студента</td>
                  <td style="text-align:center">Фамилия студента</td>
                  <td style="text-align:center">уровень iq</td>
                  <td style="text-align:center">Год рождения</td>
               </tr> 
               <xsl:for-each select="Groupmates/Student">
               <xsl:sort select="Score" data-type="number" order="descending"/>
                  <tr>
                     <xsl:choose>
                       <xsl:when test="Score &lt; 200">
                       <td bgcolor="red"><xsl:value-of select="Name" /></td>
                       </xsl:when>
                       <xsl:otherwise>
                       <td bgcolor="green"><xsl:value-of select="Name" /></td>
                       </xsl:otherwise>
                     </xsl:choose>   
                        <td><xsl:value-of select="Surname" /></td>
                        <td><xsl:value-of select="Score" /></td>
                        <td><xsl:value-of select="BirthDate" /></td>
                  </tr>
               </xsl:for-each>
            </table> 
         </body>
      </html>
   </xsl:template>
</xsl:stylesheet> 