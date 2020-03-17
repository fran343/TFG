Public Class DatosPaquete
    Dim _codigo As Integer
    Dim _ancho As Integer
    Dim _alto As Integer
    Dim _peso As Double
    Dim _origen As String
    Dim _destino As String

    Public Sub New()

    End Sub
    Public Sub New(ByVal cod As Integer, ByVal anc As Integer, ByVal alt As Integer, ByVal pes As Double, ByVal ori As String, ByVal des As String)
        Me.codigo = cod
        Me.ancho = anc
        Me.alto = alt
        Me.peso = pes
        Me.origen = ori
        Me.destino = des
    End Sub
    Public Property codigo As Integer
        Get
            Return Me._codigo
        End Get
        Set(value As Integer)
            Me._codigo = value
        End Set
    End Property

    Public Property ancho As Integer
        Get
            Return Me._ancho
        End Get
        Set(value As Integer)
            Me._ancho = value
        End Set
    End Property

    Public Property alto As Integer
        Get
            Return Me._alto
        End Get
        Set(value As Integer)
            Me._alto = value
        End Set
    End Property

    Public Property peso As Double
        Get
            Return Me._peso
        End Get
        Set(value As Double)
            Me._peso = value
        End Set
    End Property

    Public Property origen As String
        Get
            Return Me._origen
        End Get
        Set(value As String)
            Me._origen = value
        End Set
    End Property

    Public Property destino As String
        Get
            Return Me._destino
        End Get
        Set(value As String)
            Me._destino = value
        End Set
    End Property
End Class
