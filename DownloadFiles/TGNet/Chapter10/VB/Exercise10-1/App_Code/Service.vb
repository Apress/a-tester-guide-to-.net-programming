Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols

<WebService(Namespace := "http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
Public Class Service
     Inherits System.Web.Services.WebService

    Public Sub Service

    End Sub

    <WebMethod(Description:="This service calculates the area of a rectangle")> _
    Public Function RectangleArea(ByVal length As Single, ByVal width As Single) As Single
        Return length * width
    End Function

End Class
