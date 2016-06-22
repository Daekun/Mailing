<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/> 
    <xsl:template match="/">
    <html><body>
       <xsl:apply-templates/>
    </body></html>
  </xsl:template>

  <xsl:template match="/problem/title">
    <h1 align="center"> <xsl:apply-templates/> </h1>
  </xsl:template>

  <xsl:template match="/problem/data">
    <div style="float:left;width:70%;"><xsl:apply-templates/> </div>
  </xsl:template>

  <xsl:template match="/problem/data/body/text1">
    <h3> <xsl:apply-templates/> </h3>
  </xsl:template>

  <xsl:template match="/problem/data/body/text2">
    <p> <xsl:apply-templates/> </p>
  </xsl:template>

  <xsl:template match="/problem/data/body/textf">
    <div style="float:left;width:30%;"><h3> <xsl:apply-templates/> </h3></div>
  </xsl:template>

  <xsl:template match="/problem/data/question">
    <p>
      <xsl:apply-templates/>
    </p>
  </xsl:template>

</xsl:stylesheet>

