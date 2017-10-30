<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <body>
        <h2>Food List Using XSLT</h2>
        <table border="1">
          <tr bgcolor="#9acd32">
            <th style="text-align:left">Name</th>
            <th style="text-align:left">Price</th>
          </tr>
          <xsl:for-each select="breakfast_menu/food">
            <tr>
              <td>
                <xsl:value-of select="name"/>
              </td>
              <td>
                <xsl:value-of select="price"/>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>

