Imports Microsoft.Web.Services3
Imports Microsoft.Web.Services3.Security
Imports Microsoft.Web.Services3.Security.Tokens
Imports Microsoft.Web.Services3.Security.X509
Imports Microsoft.Web.Services3.Design
Imports System.Security.Cryptography
Public Class frmFACE
    Dim cert As New System.Security.Cryptography.X509Certificates.X509Certificate2("C:\DIRECTORIOCERTIFICADO\NOMBRECERTIFICADO.pfx", "PASSWORDCERTIFICADO")
    Private Sub frmFACE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnConectarFace_Click(sender As Object, e As EventArgs) Handles btnConectarFace.Click
        Dim webserviceProxy As New facewebservice.SSPPWebServiceProxyService
        webserviceProxy.ClientCertificates.Add(cert)
        Dim factura As New facewebservice.SSPPFactura
        Dim signatureToken As X509SecurityToken = GetSecurityToken()
        Dim requestContext As SoapContext = webserviceProxy.RequestSoapContext

        requestContext.Security.Tokens.Add(signatureToken)
        Dim sig As New MessageSignature(signatureToken)
        requestContext.Security.Timestamp.TtlInSeconds = 60
        requestContext.Security.Elements.Add(sig)

        Dim fra As New facewebservice.SSPPFicheroFactura()

        factura.correo = "direccion@email.com"

        Dim line As String = ""
        Try

            Using sr As New System.IO.StreamReader("C:\DIRECTORIO_DE_LA_FACTURA\NOMBREDELAFACTURA.xsig")

                line = sr.ReadToEnd()
                Console.WriteLine(line)
            End Using
        Catch ex As Exception
            Console.WriteLine("The file could not be read:")
            Console.WriteLine(ex.Message)
        End Try


        Dim fichero64 As String
        Dim byt As Byte() = System.Text.Encoding.UTF8.GetBytes(line)
        fichero64 = Convert.ToBase64String(byt)
        fra.factura = fichero64
        fra.nombre = "NOMBREDELAFACTURA.xsig"
        fra.mime = "application/xml"

        factura.fichero_factura = fra

        Try

            Dim resultadoEnvioFactura As New facewebservice.SSPPResultadoEnviarFactura
            resultadoEnvioFactura = webserviceProxy.enviarFactura(factura)
            MsgBox(resultadoEnvioFactura.codigo_registro)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Public Function GetSecurityToken() As X509SecurityToken
        Dim securityToken As X509SecurityToken = Nothing

        Try
            securityToken = New X509SecurityToken(cert)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return securityToken
    End Function

End Class
