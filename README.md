# Face-Web-Service
Aplicación Visual Basic.Net con Visual Studio 2013 para conectar con Servicio Web de Face para FacturaE

Necesitamos certificado en .pfx y FacturaE .xsig

Para utilizar los servicio web de FACE Y hay que dar de alta la parte publica del certificado en https://face.gob.es/es/proveedores (más información en http://administracionelectronica.gob.es/ctt/resources/Soluciones/334/Area%20descargas/Interfaz%20WS%20FACe-%20Proveedores%20.pdf)

Gracias a los aportes de:
sViudes Blog -  http://sviudes.blogspot.com.es/2010/05/facturae-con-net-y-c.html 
y Sourcedev.Net http://sourcedevnet.blogspot.com.es/2015/02/usar-servicios-web-de-facturae-con-c-y.html

La aplicación apunta al servicio web de producción: https://webservice.face.gob.es/sspp?wsdl
Se necesita la dll: Microsoft.Web.Services3.dll la podéis descargar instalando Web Services Enhancements (WSE) 3.0 for Microsoft .NET http://www.microsoft.com/en-us/download/details.aspx?id=14089

