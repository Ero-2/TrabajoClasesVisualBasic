Public Class persona
    Protected nombre As String
    Protected fechadenacimiento As DateTime?
    Protected correo As String
    Public Property nombre_ As String
        Get
            Return nombre
        End Get
        Set(value As String)

            nombre = value

        End Set
    End Property

    Public Property fechadenacimiento_ As DateTime

        Get
            Return fechadenacimiento
        End Get
        Set(value As DateTime)

            fechadenacimiento = value

        End Set
    End Property

    Public ReadOnly Property edad() As String

        Get
            Dim edad_ As String
            edad = (DateTime.Now.Year - fechadenacimiento.Value.Year)
            Return edad
        End Get
    End Property

    Sub persona(nombre_, fechadenacimiento_)
        nombre = nombre_
        fechadenacimiento = fechadenacimiento_
    End Sub

    Public Overrides Function ToString() As String
        Return nombre.ToUpper + " " + edad
    End Function

    Public Property Correo_ As String
        Get
            Return correo
        End Get
        Set(value As String)
            correo = value
        End Set

    End Property


End Class